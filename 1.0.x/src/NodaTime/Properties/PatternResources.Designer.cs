﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NodaTime.Properties {
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
    internal class PatternResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PatternResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NodaTime.Properties.PatternResources", typeof(PatternResources).Assembly);
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
        ///   Looks up a localized string similar to A.H.|AH.
        /// </summary>
        internal static string Eras_AnnoHegirae {
            get {
                return ResourceManager.GetString("Eras_AnnoHegirae", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A.M.|AM.
        /// </summary>
        internal static string Eras_AnnoMartyrum {
            get {
                return ResourceManager.GetString("Eras_AnnoMartyrum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to B.C.|B.C.E.|BC|BCE.
        /// </summary>
        internal static string Eras_BeforeCommon {
            get {
                return ResourceManager.GetString("Eras_BeforeCommon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A.D.|AD|C.E.|CE.
        /// </summary>
        internal static string Eras_Common {
            get {
                return ResourceManager.GetString("Eras_Common", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to +HH:mm:ss.fff.
        /// </summary>
        internal static string OffsetPatternFull {
            get {
                return ResourceManager.GetString("OffsetPatternFull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to +HH:mm:ss.
        /// </summary>
        internal static string OffsetPatternLong {
            get {
                return ResourceManager.GetString("OffsetPatternLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to +HH:mm.
        /// </summary>
        internal static string OffsetPatternMedium {
            get {
                return ResourceManager.GetString("OffsetPatternMedium", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to +HH.
        /// </summary>
        internal static string OffsetPatternShort {
            get {
                return ResourceManager.GetString("OffsetPatternShort", resourceCulture);
            }
        }
    }
}