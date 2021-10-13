using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Display.Properties
{
	// Token: 0x02000006 RID: 6
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000023F4 File Offset: 0x000005F4
		internal Resources()
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002400 File Offset: 0x00000600
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Display.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002448 File Offset: 0x00000648
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000245F File Offset: 0x0000065F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002468 File Offset: 0x00000668
		internal static Icon AppIcon
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("AppIcon", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002498 File Offset: 0x00000698
		internal static Icon AppIcon2
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("AppIcon2", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000024C8 File Offset: 0x000006C8
		internal static Icon AppIcon3
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("AppIcon3", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		// Token: 0x04000005 RID: 5
		private static ResourceManager resourceMan;

		// Token: 0x04000006 RID: 6
		private static CultureInfo resourceCulture;
	}
}
