using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Display
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000022C5 File Offset: 0x000004C5
		public Form1()
		{
			this.InitializeComponent();
			base.WindowState = FormWindowState.Minimized;
			base.ShowInTaskbar = false;
			base.ShowIcon = false;
		}
	}
}
