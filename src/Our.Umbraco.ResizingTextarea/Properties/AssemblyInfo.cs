using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Our.Umbraco.EmbeddedResource;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Our.Umbraco.ResizingTextarea")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Our.Umbraco.ResizingTextarea")]
[assembly: AssemblyCopyright("Copyright ©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("ca93fe87-1f9f-4eaa-a7ff-6dd7f3b15b9a")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.1.0.0")]
[assembly: AssemblyFileVersion("0.1.0.0")]

// register the embedded resoures (authenticated Umbraco users only)
[assembly: EmbeddedResourceProtected("Our.Umbraco.ResizeableTextarea.Resources.NullableBoolean.css", "~/App_Plugins/ResizeableTextarea/ResizeableTextarea.css")]
[assembly: EmbeddedResourceProtected("Our.Umbraco.ResizeableTextarea.Resources.NullableBoolean.html", "~/App_Plugins/ResizeableTextarea/ResizeableTextarea.html")]
[assembly: EmbeddedResourceProtected("Our.Umbraco.ResizeableTextarea.Resources.NullableBoolean.js", "~/App_Plugins/ResizeableTextarea/ResizeableTextarea.js")]