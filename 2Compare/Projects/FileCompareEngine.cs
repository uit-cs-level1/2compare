﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs511_g11
{
	public class FileCompareEngine
	{
		private TextController m_controllerFileLeft;
		private TextController m_controllerFileRight;

		private ArrayList m_matchList;
		private DifferentStateList m_stateList;

		private int GetSourceMatchLength(int destIndex, int sourceIndex, int maxLength)
		{
			int matchCount;
			for (matchCount = 0; matchCount < maxLength; matchCount++)
			{
				if (m_controllerFileRight.GetLineByIndex(destIndex + matchCount).CompareTo(m_controllerFileLeft.GetLineByIndex(sourceIndex + matchCount)) != 0)
				{
					break;
				}
			}
			return matchCount;
		}

		private void GetLongestSourceMatch(DifferentState curItem, int destIndex, int destEnd, int sourceStart, int sourceEnd)
		{

			int maxDestLength = (destEnd - destIndex) + 1;
			int curLength = 0;
			int curBestLength = 0;
			int curBestIndex = -1;
			int maxLength = 0;
			for (int sourceIndex = sourceStart; sourceIndex <= sourceEnd; sourceIndex++)
			{
				maxLength = Math.Min(maxDestLength, (sourceEnd - sourceIndex) + 1);
				if (maxLength <= curBestLength)
				{
					//No chance to find a longer one any more
					break;
				}
				curLength = GetSourceMatchLength(destIndex, sourceIndex, maxLength);
				if (curLength > curBestLength)
				{
					//This is the best match so far
					curBestIndex = sourceIndex;
					curBestLength = curLength;
				}
				//jump over the match
				sourceIndex += curBestLength;
			}
			//DiffState cur = _stateList.GetByIndex(destIndex);
			if (curBestIndex == -1)
			{
				curItem.SetNotMatched();
			}
			else
			{
				curItem.SetMatched(curBestIndex, curBestLength);
			}

		}

		private void ProcessRange(int destStart, int destEnd, int sourceStart, int sourceEnd)
		{
			int curBestIndex = -1;
			int curBestLength = -1;
			int maxPossibleDestLength = 0;
			DifferentState curItem = null;
			DifferentState bestItem = null;
			for (int destIndex = destStart; destIndex <= destEnd; destIndex++)
			{
				maxPossibleDestLength = (destEnd - destIndex) + 1;
				if (maxPossibleDestLength <= curBestLength)
				{
					//we won't find a longer one even if we looked
					break;
				}
				curItem = m_stateList.GetByIndex(destIndex);

				if (!curItem.HasValidLength(sourceStart, sourceEnd, maxPossibleDestLength))
				{
					//recalc new best length since it isn't valid or has never been done.
					GetLongestSourceMatch(curItem, destIndex, destEnd, sourceStart, sourceEnd);
				}
				if (curItem.Status == BlockStatus.Matched)
				{
					if (curItem.Length > curBestLength)
					{
						//this is longest match so far
						curBestIndex = destIndex;
						curBestLength = curItem.Length;
						bestItem = curItem;
					}
					//Jump over the match 
					destIndex += curItem.Length - 1;
				}
			}
			if (curBestIndex < 0)
			{
				//we are done - there are no matches in this span
			}
			else
			{

				int sourceIndex = bestItem.StartIndex;
				m_matchList.Add(DifferentResult.CreateNoChange(curBestIndex, sourceIndex, curBestLength));
				if (destStart < curBestIndex)
				{
					//Still have more lower destination data
					if (sourceStart < sourceIndex)
					{
						//Still have more lower source data
						// Recursive call to process lower indexes
						ProcessRange(destStart, curBestIndex - 1, sourceStart, sourceIndex - 1);
					}
				}
				int upperDestStart = curBestIndex + curBestLength;
				int upperSourceStart = sourceIndex + curBestLength;
				if (destEnd > upperDestStart)
				{
					//we still have more upper dest data
					if (sourceEnd > upperSourceStart)
					{
						//set still have more upper source data
						// Recursive call to process upper indexes
						ProcessRange(upperDestStart, destEnd, upperSourceStart, sourceEnd);
					}
				}
			}
		}

		public void Setup(TextController controllerFileLeft, TextController controllerFileRight)
		{
			m_controllerFileLeft = controllerFileLeft;
			m_controllerFileRight = controllerFileRight;
		}

		public double Execute()
		{
			DateTime dt = DateTime.Now;
			m_matchList = new ArrayList();

			int dcount = m_controllerFileRight.Count();
			int scount = m_controllerFileLeft.Count();


			if ((dcount > 0) && (scount > 0))
			{
				m_stateList = new DifferentStateList(dcount);
				ProcessRange(0, dcount - 1, 0, scount - 1);
			}

			TimeSpan ts = DateTime.Now - dt;
			return ts.TotalSeconds;
		}


		private bool AddChanges(ArrayList report, int curDest, int nextDest, int curSource, int nextSource)
		{
			bool retval = false;
			int diffDest = nextDest - curDest;
			int diffSource = nextSource - curSource;
			int minDiff = 0;
			if (diffDest > 0)
			{
				if (diffSource > 0)
				{
					minDiff = Math.Min(diffDest, diffSource);
					report.Add(DifferentResult.CreateReplace(curDest, curSource, minDiff));
					if (diffDest > diffSource)
					{
						curDest += minDiff;
						report.Add(DifferentResult.CreateAddDestination(curDest, diffDest - diffSource));
					}
					else
					{
						if (diffSource > diffDest)
						{
							curSource += minDiff;
							report.Add(DifferentResult.CreateDeleteSource(curSource, diffSource - diffDest));
						}
					}
				}
				else
				{
					report.Add(DifferentResult.CreateAddDestination(curDest, diffDest));
				}
				retval = true;
			}
			else
			{
				if (diffSource > 0)
				{
					report.Add(DifferentResult.CreateDeleteSource(curSource, diffSource));
					retval = true;
				}
			}
			return retval;
		}

		public ArrayList GetResult()
		{
			ArrayList retval = new ArrayList();
			int dcount = m_controllerFileRight.Count();
			int scount = m_controllerFileLeft.Count();

			//Deal with the special case of empty files
			if (dcount == 0)
			{
				if (scount > 0)
				{
					retval.Add(DifferentResult.CreateDeleteSource(0, scount));
				}
				return retval;
			}
			else
			{
				if (scount == 0)
				{
					retval.Add(DifferentResult.CreateAddDestination(0, dcount));
					return retval;
				}
			}


			m_matchList.Sort();
			int curDest = 0;
			int curSource = 0;
			DifferentResult last = null;

			//Process each match record
			foreach (DifferentResult drs in m_matchList)
			{
				if ((!AddChanges(retval, curDest, drs.DestIndex, curSource, drs.SourceIndex)) &&
					(last != null))
				{
					last.AddLength(drs.Length);
				}
				else
				{
					retval.Add(drs);
				}
				curDest = drs.DestIndex + drs.Length;
				curSource = drs.SourceIndex + drs.Length;
				last = drs;
			}

			//Process any tail end data
			AddChanges(retval, curDest, dcount, curSource, scount);

			return retval;
		}
	}
}
