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
		MenuItem menuItem = new MenuItem("Working");
		MenuItem menuItem2 = new MenuItem("Double Layout");
		MenuItem item = new MenuItem("First", new EventHandler(this.setSingleLeft));
		MenuItem item2 = new MenuItem("Second", new EventHandler(this.setSingleMiddle));
		MenuItem item3 = new MenuItem("Third", new EventHandler(this.setSingleRight));
		menuItem.MenuItems.Add(item);
		menuItem.MenuItems.Add(item2);
		menuItem.MenuItems.Add(item3);
		this.trayIcon = new NotifyIcon
		{
			Icon = Resources.AppIcon3,
			ContextMenu = new ContextMenu(new MenuItem[]
			{
				menuItem,
				menuItem2,
				new MenuItem("-"),
				new MenuItem("Exit", new EventHandler(this.Exit))
			}),
			Visible = true
		};
	}

	private void Exit(object sender, EventArgs e)
	{
		this.trayIcon.Visible = false;
		Application.Exit();
	}

	private void setSingleRight(object sender, EventArgs e)
	{
		this.trayIcon.Icon = Resources.AppIcon3;
	}

	private void setSingleMiddle(object sender, EventArgs e)
	{
		this.trayIcon.Icon = Resources.AppIcon2;
	}

	private void setSingleLeft(object sender, EventArgs e)
	{
		this.trayIcon.Icon = Resources.AppIcon;
	}


	private NotifyIcon trayIcon;
}
