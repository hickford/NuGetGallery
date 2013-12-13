﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Services {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Services.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Expected a name in the format: &apos;&lt;index&gt;-&lt;id&gt;&apos;.
        /// </summary>
        internal static string Datacenter_InvalidName {
            get {
                return ResourceManager.GetString("Datacenter_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a name in the format: &quot;&lt;environment&gt;_DC&lt;datacenter id&gt;&quot;.
        /// </summary>
        internal static string DatacenterName_InvalidName {
            get {
                return ResourceManager.GetString("DatacenterName_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host must be set using SetHost before invoking this method..
        /// </summary>
        internal static string NuGetService_HostNotSet {
            get {
                return ResourceManager.GetString("NuGetService_HostNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Sql Server: {0}.
        /// </summary>
        internal static string ServiceConfiguration_UnknownSqlServer {
            get {
                return ResourceManager.GetString("ServiceConfiguration_UnknownSqlServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Storage Account: {0}.
        /// </summary>
        internal static string ServiceConfiguration_UnknownStorageAccount {
            get {
                return ResourceManager.GetString("ServiceConfiguration_UnknownStorageAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This host does not support IP endpoints.
        /// </summary>
        internal static string ServiceHost_DoesNotSupportEndpoints {
            get {
                return ResourceManager.GetString("ServiceHost_DoesNotSupportEndpoints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid NuGetService, it must inherit from NuGet.Services.NuGetService.
        /// </summary>
        internal static string ServiceHost_NotAValidServiceType {
            get {
                return ResourceManager.GetString("ServiceHost_NotAValidServiceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a name in the format: &quot;&lt;environment&gt;_DC&lt;datacenter id&gt;_&lt;name&gt;&quot;.
        /// </summary>
        internal static string ServiceHostName_InvalidName {
            get {
                return ResourceManager.GetString("ServiceHostName_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a name in the format: &quot;&lt;environment&gt;_DC&lt;datacenter id&gt;_&lt;service host name&gt;_&lt;service name&gt;_IN&lt;service instance index&gt;&quot;.
        /// </summary>
        internal static string ServiceInstanceName_InvalidName {
            get {
                return ResourceManager.GetString("ServiceInstanceName_InvalidName", resourceCulture);
            }
        }
    }
}
