﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1 {
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
    internal class resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ConsoleApplication1.resource", typeof(resource).Assembly);
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
        ///   Looks up a localized string similar to O formato da cadeia de inicialização não está de acordo com a especificação iniciada no índice 0..
        /// </summary>
        internal static string criptografadoSICOF {
            get {
                return ResourceManager.GetString("criptografadoSICOF", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .\SQLEXPRESS.
        /// </summary>
        internal static string defaultConnection {
            get {
                return ResourceManager.GetString("defaultConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erro: {0}; Site name: {1}; AppName: {2}.
        /// </summary>
        internal static string errorString {
            get {
                return ResourceManager.GetString("errorString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Site name: {0}; AppName: {1}; DataSource: {2}; Database: {3}.
        /// </summary>
        internal static string resultString {
            get {
                return ResourceManager.GetString("resultString", resourceCulture);
            }
        }
    }
}
