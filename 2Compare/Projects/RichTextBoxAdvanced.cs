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
	public partial class RichTextBoxAdvanced : RichTextBox
	{
		private const int WM_VSCROLL = 0x115;
		private const int WM_HSCROLL = 0x114;
		private const int WM_MOUSEWHEEL = 0x20a;

		private List<RichTextBoxAdvanced> peers = new List<RichTextBoxAdvanced>();

		public RichTextBoxAdvanced()
		{
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		}

		/// <summary>
		/// Establish a 2-way binding between RTBs for scrolling.
		/// </summary>
		/// <param name="arg">Another RTB</param>
		public void BindScroll(RichTextBoxAdvanced arg)
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
				foreach (RichTextBoxAdvanced peer in this.peers)
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

		public TextController m_textController;
		public string m_path;
	}
}
