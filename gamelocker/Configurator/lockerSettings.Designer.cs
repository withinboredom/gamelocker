﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Configurator {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class lockerSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static lockerSettings defaultInstance = ((lockerSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new lockerSettings())));
        
        public static lockerSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>begin</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection fileList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["fileList"]));
            }
            set {
                this["fileList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>begin</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection fileMap {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["fileMap"]));
            }
            set {
                this["fileMap"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:05:00")]
        public global::System.TimeSpan checkInWait {
            get {
                return ((global::System.TimeSpan)(this["checkInWait"]));
            }
            set {
                this["checkInWait"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:30:00")]
        public global::System.TimeSpan timedGame {
            get {
                return ((global::System.TimeSpan)(this["timedGame"]));
            }
            set {
                this["timedGame"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int probability {
            get {
                return ((int)(this["probability"]));
            }
            set {
                this["probability"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:30:00")]
        public global::System.TimeSpan waitToPlay {
            get {
                return ((global::System.TimeSpan)(this["waitToPlay"]));
            }
            set {
                this["waitToPlay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:01:00")]
        public global::System.TimeSpan incorrectWait {
            get {
                return ((global::System.TimeSpan)(this["incorrectWait"]));
            }
            set {
                this["incorrectWait"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2009-12-23")]
        public global::System.DateTime lastTry {
            get {
                return ((global::System.DateTime)(this["lastTry"]));
            }
            set {
                this["lastTry"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool alertBeforeKill {
            get {
                return ((bool)(this["alertBeforeKill"]));
            }
            set {
                this["alertBeforeKill"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool alertAudible {
            get {
                return ((bool)(this["alertAudible"]));
            }
            set {
                this["alertAudible"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool alertVisual {
            get {
                return ((bool)(this["alertVisual"]));
            }
            set {
                this["alertVisual"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool alertTakeFocus {
            get {
                return ((bool)(this["alertTakeFocus"]));
            }
            set {
                this["alertTakeFocus"] = value;
            }
        }
    }
}