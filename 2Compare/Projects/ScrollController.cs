using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs511_g11
{
	class RichTextBoxSynchronizedScroll : RichTextBox
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
	}
}
