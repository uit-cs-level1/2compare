using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs511_g11
{
	internal enum BlockStatus
	{
		Matched = 1,
		NotMatched = -1,
		Unknown = -2

	}

	internal class DifferentState
	{
		private const int BAD_INDEX = -1;
		private int m_startIndex;
		private int m_length;

		public int StartIndex { get { return m_startIndex; } }
		public int EndIndex { get { return ((m_startIndex + m_length) - 1); } }
		public int Length
		{
			get
			{
				int len;
				if (m_length > 0)
				{
					len = m_length;
				}
				else
				{
					if (m_length == 0)
					{
						len = 1;
					}
					else
					{
						len = 0;
					}
				}
				return len;
			}
		}
		public BlockStatus Status
		{
			get
			{
				BlockStatus stat;
				if (m_length > 0)
				{
					stat = BlockStatus.Matched;
				}
				else
				{
					switch (m_length)
					{
						case -1:
							stat = BlockStatus.NotMatched;
							break;
						default:
							System.Diagnostics.Debug.Assert(m_length == -2, "Invalid status: _length < -2");
							stat = BlockStatus.Unknown;
							break;
					}
				}
				return stat;
			}
		}

		public DifferentState()
		{
			SetToUnknown();
		}

		protected void SetToUnknown()
		{
			m_startIndex = BAD_INDEX;
			m_length = (int)BlockStatus.Unknown;
		}

		public void SetMatched(int start, int length)
		{
			System.Diagnostics.Debug.Assert(length > 0, "Length must be greater than zero");
			System.Diagnostics.Debug.Assert(start >= 0, "Start must be greater than or equal to zero");
			m_startIndex = start;
			m_length = length;
		}

		public void SetNotMatched()
		{
			m_startIndex = BAD_INDEX;
			m_length = (int)BlockStatus.NotMatched;
		}


		public bool HasValidLength(int newStart, int newEnd, int maxPossibleDestLength)
		{
			if (m_length > 0) //have unlocked match
			{
				if ((maxPossibleDestLength < m_length) ||
					((m_startIndex < newStart) || (EndIndex > newEnd)))
				{
					SetToUnknown();
				}
			}
			return (m_length != (int)BlockStatus.Unknown);
		}
	}

	internal class DifferentStateList
	{
#if USE_HASH_TABLE
		private Hashtable _table;
#else
		private DifferentState[] _array;
#endif
		public DifferentStateList(int destCount)
		{
#if USE_HASH_TABLE
			_table = new Hashtable(Math.Max(9,destCount/10));
#else
			_array = new DifferentState[destCount];
#endif
		}

		public DifferentState GetByIndex(int index)
		{
#if USE_HASH_TABLE
			DifferentState retval = (DifferentState)_table[index];
			if (retval == null)
			{
				retval = new DifferentState();
				_table.Add(index,retval);
			}
#else
			DifferentState retval = _array[index];
			if (retval == null)
			{
				retval = new DifferentState();
				_array[index] = retval;
			}
#endif
			return retval;
		}
	}


	public enum ResultStatus
	{
		SameText,
		DiffrenentText,
		RightNotExist,
		LeftNotExist
	}

	public class DifferentResult : IComparable
	{
		private const int BAD_INDEX = -1;
		private int _destIndex;
		private int _sourceIndex;
		private int _length;
		private ResultStatus _status;

		public int DestIndex { get { return _destIndex; } }
		public int SourceIndex { get { return _sourceIndex; } }
		public int Length { get { return _length; } }
		public ResultStatus Status { get { return _status; } }

		protected DifferentResult(
			ResultStatus status,
			int destIndex,
			int sourceIndex,
			int length)
		{
			_status = status;
			_destIndex = destIndex;
			_sourceIndex = sourceIndex;
			_length = length;
		}

		public static DifferentResult CreateNoChange(int destIndex, int sourceIndex, int length)
		{
			return new DifferentResult(ResultStatus.SameText, destIndex, sourceIndex, length);
		}

		public static DifferentResult CreateReplace(int destIndex, int sourceIndex, int length)
		{
			return new DifferentResult(ResultStatus.DiffrenentText, destIndex, sourceIndex, length);
		}

		public static DifferentResult CreateDeleteSource(int sourceIndex, int length)
		{
			return new DifferentResult(ResultStatus.RightNotExist, BAD_INDEX, sourceIndex, length);
		}

		public static DifferentResult CreateAddDestination(int destIndex, int length)
		{
			return new DifferentResult(ResultStatus.LeftNotExist, destIndex, BAD_INDEX, length);
		}

		public void AddLength(int i)
		{
			_length += i;
		}

		public override string ToString()
		{
			return string.Format("{0} (Dest: {1},Source: {2}) {3}",
				_status.ToString(),
				_destIndex.ToString(),
				_sourceIndex.ToString(),
				_length.ToString());
		}
		#region IComparable Members

		public int CompareTo(object obj)
		{
			return _destIndex.CompareTo(((DifferentResult)obj)._destIndex);
		}

		#endregion
	}
}
