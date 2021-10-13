using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Display
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resource1
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002382 File Offset: 0x00000582
		internal Resource1()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000238C File Offset: 0x0000058C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resource1.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Display.Resource1", typeof(Resource1).Assembly);
					Resource1.resourceMan = resourceManager;
				}
				return Resource1.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000023D4 File Offset: 0x000005D4
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000023EB File Offset: 0x000005EB
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resource1.resourceCulture;
			}
			set
			{
				Resource1.resourceCulture = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static ResourceManager resourceMan;

		// Token: 0x04000004 RID: 4
		private static CultureInfo resourceCulture;
	}
}
