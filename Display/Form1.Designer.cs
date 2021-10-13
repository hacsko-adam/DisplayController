namespace Display
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000022F8 File Offset: 0x000004F8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000232F File Offset: 0x0000052F
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			this.Text = "Form1";
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components = null;
	}
}
