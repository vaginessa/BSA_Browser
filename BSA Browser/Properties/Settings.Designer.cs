﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BSA_Browser.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\")]
        public string LastBSAUnpackPath {
            get {
                return ((string)(this["LastBSAUnpackPath"]));
            }
            set {
                this["LastBSAUnpackPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentFiles"]));
            }
            set {
                this["RecentFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int RecentFiles_MaxFiles {
            get {
                return ((int)(this["RecentFiles_MaxFiles"]));
            }
            set {
                this["RecentFiles_MaxFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpdateSettings {
            get {
                return ((bool)(this["UpdateSettings"]));
            }
            set {
                this["UpdateSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::BSA_Browser.Classes.WindowStates WindowStates {
            get {
                return ((global::BSA_Browser.Classes.WindowStates)(this["WindowStates"]));
            }
            set {
                this["WindowStates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SortDesc {
            get {
                return ((bool)(this["SortDesc"]));
            }
            set {
                this["SortDesc"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FolderName")]
        public global::BSA_Browser.BSASortOrder SortType {
            get {
                return ((global::BSA_Browser.BSASortOrder)(this["SortType"]));
            }
            set {
                this["SortType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::BSA_Browser.Classes.QuickExtractPaths QuickExtractPaths {
            get {
                return ((global::BSA_Browser.Classes.QuickExtractPaths)(this["QuickExtractPaths"]));
            }
            set {
                this["QuickExtractPaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SortBSADirectories {
            get {
                return ((bool)(this["SortBSADirectories"]));
            }
            set {
                this["SortBSADirectories"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExtractMaintainFolderStructure {
            get {
                return ((bool)(this["ExtractMaintainFolderStructure"]));
            }
            set {
                this["ExtractMaintainFolderStructure"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SearchUseRegex {
            get {
                return ((bool)(this["SearchUseRegex"]));
            }
            set {
                this["SearchUseRegex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MoreColumns {
            get {
                return ((bool)(this["MoreColumns"]));
            }
            set {
                this["MoreColumns"] = value;
            }
        }
    }
}
