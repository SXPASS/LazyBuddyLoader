using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace LazyBuddy_Loader.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (LazyBuddy_Loader.Properties.Resources.resourceMan == null)
          LazyBuddy_Loader.Properties.Resources.resourceMan = new ResourceManager("LazyBuddy_Loader.Properties.Resources", typeof (LazyBuddy_Loader.Properties.Resources).Assembly);
        return LazyBuddy_Loader.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return LazyBuddy_Loader.Properties.Resources.resourceCulture;
      }
      set
      {
        LazyBuddy_Loader.Properties.Resources.resourceCulture = value;
      }
    }

    internal Resources()
    {
    }
  }
}
