﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfTemplateStudio.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WpfTemplateStudio.Core.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to remove backgroud.
        /// </summary>
        public static string BackgroundRemoverService_RemoveBackground_FailedToRemoveBackgroud {
            get {
                return ResourceManager.GetString("BackgroundRemoverService_RemoveBackground_FailedToRemoveBackgroud", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deserialization failed..
        /// </summary>
        public static string ObjectSerializer_ByteArrayToObject_DeserializationFailed {
            get {
                return ResourceManager.GetString("ObjectSerializer_ByteArrayToObject_DeserializationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Serialization failed..
        /// </summary>
        public static string ObjectSerializer_ObjectToByteArray_SerializationFailed {
            get {
                return ResourceManager.GetString("ObjectSerializer_ObjectToByteArray_SerializationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initialized Python version: .
        /// </summary>
        public static string PythonInitializerService_Initialize_InitializedPythonVersion {
            get {
                return ResourceManager.GetString("PythonInitializerService_Initialize_InitializedPythonVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \\.conda.
        /// </summary>
        public static string PythonInitializerService_PythonInitializerService_Conda {
            get {
                return ResourceManager.GetString("PythonInitializerService_PythonInitializerService_Conda", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get current directory..
        /// </summary>
        public static string PythonInitializerService_PythonInitializerService_FailedToGetCurrentDirectory {
            get {
                return ResourceManager.GetString("PythonInitializerService_PythonInitializerService_FailedToGetCurrentDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get PATH environment variable..
        /// </summary>
        public static string PythonInitializerService_PythonInitializerService_FailedToGetPATHEnvironmentVariable {
            get {
                return ResourceManager.GetString("PythonInitializerService_PythonInitializerService_FailedToGetPATHEnvironmentVaria" +
                        "ble", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \\python312.dll.
        /// </summary>
        public static string PythonInitializerService_PythonInitializerService_PythonDll {
            get {
                return ResourceManager.GetString("PythonInitializerService_PythonInitializerService_PythonDll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Python initialization failed..
        /// </summary>
        public static string PythonInitializerService_PythonInitializerService_PythonInitializationFailed {
            get {
                return ResourceManager.GetString("PythonInitializerService_PythonInitializerService_PythonInitializationFailed", resourceCulture);
            }
        }
    }
}
