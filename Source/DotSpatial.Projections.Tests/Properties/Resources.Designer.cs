﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotSpatial.Projections.Tests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotSpatial.Projections.Tests.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PROJCS[&quot;WGS_1984_Web_Mercator_Auxiliary_Sphere&quot;,
        ///	GEOGCS[&quot;GCS_WGS_1984&quot;,
        ///		DATUM[&quot;D_WGS_1984&quot;,
        ///			SPHEROID[&quot;WGS_1984&quot;, 6378137, 298.257223562997]
        ///		],
        ///		PRIMEM[&quot;Greenwich&quot;, 0],
        ///		UNIT[&quot;Degree&quot;, 0.0174532925199433]
        ///	],
        ///	PROJECTION[&quot;Mercator_Auxiliary_Sphere&quot;],
        ///	PARAMETER[&quot;False_Easting&quot;, 0],
        ///	PARAMETER[&quot;False_Northing&quot;, 0],
        ///	PARAMETER[&quot;Central_Meridian&quot;, 0],
        ///	PARAMETER[&quot;Standard_Parallel_1&quot;, 0],
        ///	PARAMETER[&quot;Scale_Factor&quot;, 1],
        ///	PARAMETER[&quot;Auxiliary_Sphere_Type&quot;, 0.0],
        ///	UNIT[&quot;Meter&quot;, 1]
        ///]
        ///.
        /// </summary>
        internal static string FormattedProjectionFile {
            get {
                return ResourceManager.GetString("FormattedProjectionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PROJCS[&quot;WGS_1984_Web_Mercator_Auxiliary_Sphere&quot;,GEOGCS[&quot;GCS_WGS_1984&quot;,DATUM[&quot;D_WGS_1984&quot;,SPHEROID[&quot;WGS_1984&quot;,6378137,298.257223562997]],PRIMEM[&quot;Greenwich&quot;,0],UNIT[&quot;Degree&quot;,0.0174532925199433]], PROJECTION[&quot;Mercator_Auxiliary_Sphere&quot;],PARAMETER[&quot;False_Easting&quot;,0],PARAMETER[&quot;False_Northing&quot;,0],PARAMETER[&quot;Central_Meridian&quot;,0],PARAMETER[&quot;Standard_Parallel_1&quot;,0],PARAMETER[&quot;Scale_Factor&quot;,1],PARAMETER[&quot;Auxiliary_Sphere_Type&quot;,0.0],UNIT[&quot;Meter&quot;,1]]
        ///.
        /// </summary>
        internal static string StandardProjectionFile {
            get {
                return ResourceManager.GetString("StandardProjectionFile", resourceCulture);
            }
        }
    }
}
