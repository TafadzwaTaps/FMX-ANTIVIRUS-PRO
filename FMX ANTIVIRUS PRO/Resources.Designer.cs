// ------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// Runtime Version:4.0.30319.42000
// 
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic;

namespace FMX_ANTIVIRUS_PRO.My.Resources
{

    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    /// <summary>
    /// A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [DebuggerNonUserCode()]
    [System.Runtime.CompilerServices.CompilerGenerated()]
    [HideModuleName()]
    internal static class Resources
    {
        private static System.Resources.ResourceManager resourceMan;
        private static System.Globalization.CultureInfo resourceCulture;

        /// <summary>
        /// Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (ReferenceEquals(resourceMan, null))
                {
                    var temp = new System.Resources.ResourceManager("FMX_ANTIVIRUS_PRO.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }

                return resourceMan;
            }
        }

        /// <summary>
        /// Overrides the current thread's CurrentUICulture property for all
        /// resource lookups using this strongly typed resource class.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }

            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        /// Looks up a localized string similar to L.AddRange(GETFILES(DD.FullName)).
        /// </summary>
        internal static string _String
        {
            get
            {
                return ResourceManager.GetString("String", resourceCulture);
            }
        }

        /// <summary>
        /// Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static Bitmap images
        {
            get
            {
                var obj = ResourceManager.GetObject("images", resourceCulture);
                return (Bitmap)obj;
            }
        }

        /// <summary>
        /// Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static Bitmap images__2___1_
        {
            get
            {
                var obj = ResourceManager.GetObject("images (2) (1)", resourceCulture);
                return (Bitmap)obj;
            }
        }
    }
}