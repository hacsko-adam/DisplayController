using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Display.Properties;

// Token: 0x02000002 RID: 2
public class MyCustomApplicationContext : ApplicationContext
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	public MyCustomApplicationContext()
	{
		MenuItem menuItem = new MenuItem("Single Layout");
		MenuItem menuItem2 = new MenuItem("Double Layout");
		MenuItem menuItem3 = new MenuItem("Triple Layout", new EventHandler(this.setTripleLayout));
		MenuItem item = new MenuItem("Left", new EventHandler(this.setSingleLeft));
		MenuItem item2 = new MenuItem("Middle", new EventHandler(this.setSingleMiddle));
		MenuItem item3 = new MenuItem("Right", new EventHandler(this.setSingleRight));
		MenuItem item4 = new MenuItem("Left", new EventHandler(this.setDoubleLeft));
		MenuItem item5 = new MenuItem("Right", new EventHandler(this.setDoubleRight));
		menuItem.MenuItems.Add(item);
		menuItem.MenuItems.Add(item2);
		menuItem.MenuItems.Add(item3);
		menuItem2.MenuItems.Add(item4);
		menuItem2.MenuItems.Add(item5);
		this.trayIcon = new NotifyIcon
		{
			Icon = Resources.AppIcon3,
			ContextMenu = new ContextMenu(new MenuItem[]
			{
				menuItem3,
				menuItem2,
				menuItem,
				new MenuItem("-"),
				new MenuItem("Exit", new EventHandler(this.Exit))
			}),
			Visible = true
		};
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000021B8 File Offset: 0x000003B8
	private void Exit(object sender, EventArgs e)
	{
		this.trayIcon.Visible = false;
		Application.Exit();
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000021CE File Offset: 0x000003CE
	private void setSingleRight(object sender, EventArgs e)
	{
		this.setTripleLayout(sender, e);
		this.ProcessStarter("D:\\Downloads\\multimonitortool-x64\\new\\single_right.cfg");
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000021E6 File Offset: 0x000003E6
	private void setSingleMiddle(object sender, EventArgs e)
	{
		this.setTripleLayout(sender, e);
		this.ProcessStarter("D:\\Downloads\\multimonitortool-x64\\new\\single_middle.cfg");
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000021FE File Offset: 0x000003FE
	private void setSingleLeft(object sender, EventArgs e)
	{
		this.setTripleLayout(sender, e);
		this.ProcessStarter("D:\\Downloads\\multimonitortool-x64\\new\\single_left.cfg");
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002216 File Offset: 0x00000416
	private void setDoubleRight(object sender, EventArgs e)
	{
		this.setTripleLayout(sender, e);
		this.ProcessStarter("D:\\Downloads\\multimonitortool-x64\\new\\double_right.cfg");
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000222E File Offset: 0x0000042E
	private void setDoubleLeft(object sender, EventArgs e)
	{
		this.setTripleLayout(sender, e);
		this.ProcessStarter("D:\\Downloads\\multimonitortool-x64\\new\\double_left.cfg");
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002248 File Offset: 0x00000448
	private void setTripleLayout(object sender, EventArgs e)
	{
		bool flag = Screen.AllScreens.Count<Screen>() == 1;
		if (flag)
		{
			this.ProcessStarter("D:\\Downloads\\multimonitortool-x64\\new\\triple.cfg");
			Thread.Sleep(2000);
		}
		this.ProcessStarter("D:\\Downloads\\multimonitortool-x64\\new\\triple.cfg");
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000228C File Offset: 0x0000048C
	private void ProcessStarter(string PathToCfg)
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = "MultiMonitorTool.exe",
			Arguments = "/LoadConfig " + PathToCfg
		});
	}

	// Token: 0x04000001 RID: 1
	private NotifyIcon trayIcon;
}
