using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs511_g11
{
	public class RichTextBoxSynchronizedScroll : RichTextBox
	{
		private const int WM_VSCROLL = 0x115;
		private const int WM_HSCROLL = 0x114;
		private const int WM_MOUSEWHEEL = 0x20a;

		private List<RichTextBoxSynchronizedScroll> peers = new List<RichTextBoxSynchronizedScroll>();

		/// <summary>
		/// Establish a 2-way binding between RTBs for scrolling.
		/// </summary>
		/// <param name="arg">Another RTB</param>
		public void BindScroll(RichTextBoxSynchronizedScroll arg)
		{
			if (peers.Contains(arg) || arg == this) { return; }
			peers.Add(arg);
			arg.BindScroll(this);
		}

		private void DirectWndProc(ref Message m)
		{
			base.WndProc(ref m);
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_VSCROLL || m.Msg == WM_HSCROLL || m.Msg == WM_MOUSEWHEEL)
			{
				foreach (RichTextBoxSynchronizedScroll peer in this.peers)
				{
					Message peerMessage = Message.Create(peer.Handle, m.Msg, m.WParam, m.LParam);
					peer.DirectWndProc(ref peerMessage);
				}
			}

			base.WndProc(ref m);
		}



		private LastHighlight mLastHighlight = new LastHighlight(0, Rectangle.Empty);

		private class LastHighlight
		{
			public int mCharIndex;
			public Rectangle mRectangle;

			public LastHighlight(int index, Rectangle r)
			{
				mCharIndex = index;
				mRectangle = r;
			}
		}

		public void PaintLineHighlight()
		{
			using (Graphics g = this.CreateGraphics())
			{
				// highlight color
				Color c = Color.Beige;
				// current pen color
				Pen cp = new Pen(Color.Beige);
				// color for removing highlight
				Pen lp = new Pen(this.BackColor);
				// brush for removing highlight
				SolidBrush lb = new SolidBrush(this.BackColor);
				// brush for applying highlight
				SolidBrush cb = new SolidBrush(Color.FromArgb(64, c.R, c.G, c.B));
				// index of the current line
				int index = this.GetFirstCharIndexOfCurrentLine();
				// rectangle to specify which region to paint too
				Rectangle r = new Rectangle();

				// specify dimensions
				r.X = 0;
				r.Y = this.GetPositionFromCharIndex(index).Y;
				r.Width = this.HorizontalScrollBarWidth();
				r.Height = Convert.ToInt32(this.Font.Height * this.ZoomFactor);

				// this will always be true unless the current line remains the same
				if (!(mLastHighlight.mCharIndex == index) && !(mLastHighlight.mRectangle == r))
				{
					// remove the last highlight. regardless of the brush specified, white is always applied, and the text is painted over
					//g.DrawRectangle(lp, mLastHighlight.mRectangle);
					//g.FillRectangle(lb, mLastHighlight.mRectangle);
					// apply highlight to the current line
					g.DrawRectangle(cp, r);
					g.FillRectangle(cb, r);
				}

				mLastHighlight = new LastHighlight(index, r);
			}
		}

		#region RichScrollBars
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetScrollInfo(IntPtr hWnd, int fnBar, ref SCROLLINFO si);

		[StructLayout(LayoutKind.Sequential)]
		public class SCROLLINFO
		{
			public int cbSize;
			public int fMask;
			public int nMin;
			public int nMax;
			public int nPage;
			public int nPos;
			public int nTrackPos;
			public SCROLLINFO()
			{
				this.cbSize = Marshal.SizeOf(typeof(SCROLLINFO));
			}

			public SCROLLINFO(int mask, int min, int max, int page, int pos)
			{
				this.cbSize = Marshal.SizeOf(typeof(SCROLLINFO));
				this.fMask = mask;
				this.nMin = min;
				this.nMax = max;
				this.nPage = page;
				this.nPos = pos;
			}
		}

		private const int SIF_ALL = 0X17;
		private const int SB_HORZ = 0;
		private const int SB_VERT = 1;

		public int HorizontalScrollBarWidth()
		{
			SCROLLINFO si = new SCROLLINFO() { fMask = SIF_ALL };
			GetScrollInfo(this.Handle, SB_HORZ, ref si);

			return Math.Max(si.nMax, this.Width);
		}

		public int VerticalScrollBarHeight()
		{
			SCROLLINFO si = new SCROLLINFO() { fMask = SIF_ALL };
			GetScrollInfo(this.Handle, SB_VERT, ref si);

			return Math.Max(si.nMax, this.Height);
		}
		#endregion
	}
}
