﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlickrSync.Properties {
	
	
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("ICSharpCode.SettingsEditor.SettingsCodeGeneratorTool", "4.3.1.9430")]
	internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
		
		private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
		
		public static Settings Default {
			get {
				return defaultInstance;
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>jpg</string>
  <string>jpeg</string>
  <string>gif</string>
  <string>png</string>
  <string>tif</string>
  <string>tiff</string>
  <string>bmp</string>
</ArrayOfString>")]
		public global::System.Collections.Specialized.StringCollection Extensions {
			get {
				return ((global::System.Collections.Specialized.StringCollection)(this["Extensions"]));
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("99835d77b01b776f3115b56180c6c4f4")]
		public string FlickrApiKey {
			get {
				return ((string)(this["FlickrApiKey"]));
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("3433f92c86ec38f3")]
		public string FlickrShared {
			get {
				return ((string)(this["FlickrShared"]));
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("")]
		public string FlickrToken {
			get {
				return ((string)(this["FlickrToken"]));
			}
			set {
				this["FlickrToken"] = value;
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("http://flickrsync.freehostia.com/index.htm")]
		public string HelpMain {
			get {
				return ((string)(this["HelpMain"]));
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("http://flickrsync.freehostia.com/index_properties.htm")]
		public string HelpProperties {
			get {
				return ((string)(this["HelpProperties"]));
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("70")]
		public string ItemLimit {
			get {
				return ((string)(this["ItemLimit"]));
			}
			set {
				this["ItemLimit"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("")]
		public string LastFolder {
			get {
				return ((string)(this["LastFolder"]));
			}
			set {
				this["LastFolder"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("<FlickrSync></FlickrSync>")]
		public string LocalInfoXml {
			get {
				return ((string)(this["LocalInfoXml"]));
			}
			set {
				this["LocalInfoXml"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute(".log")]
		public string LogFile {
			get {
				return ((string)(this["LogFile"]));
			}
			set {
				this["LogFile"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("LogBasic")]
		public string LogLevel {
			get {
				return ((string)(this["LogLevel"]));
			}
			set {
				this["LogLevel"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("MessagesAll")]
		public string MessageLevel {
			get {
				return ((string)(this["MessageLevel"]));
			}
			set {
				this["MessageLevel"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("SyncFilename")]
		public string Method {
			get {
				return ((string)(this["Method"]));
			}
			set {
				this["Method"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("False")]
		public bool NoDelete {
			get {
				return ((bool)(this["NoDelete"]));
			}
			set {
				this["NoDelete"] = value;
			}
		}
		
				
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("False")]
		public bool Children {
			get {
				return ((bool)(this["Children"]));
			}
			set {
				this["Children"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("False")]
		public bool NoDeleteTags {
			get {
				return ((bool)(this["NoDeleteTags"]));
			}
			set {
				this["NoDeleteTags"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("OrderDefault")]
		public string OrderType {
			get {
				return ((string)(this["OrderType"]));
			}
			set {
				this["OrderType"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("")]
		public string ProxyHost {
			get {
				return ((string)(this["ProxyHost"]));
			}
			set {
				this["ProxyHost"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("")]
		public string ProxyPass {
			get {
				return ((string)(this["ProxyPass"]));
			}
			set {
				this["ProxyPass"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("")]
		public string ProxyPort {
			get {
				return ((string)(this["ProxyPort"]));
			}
			set {
				this["ProxyPort"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("False")]
		public bool ProxyUse {
			get {
				return ((bool)(this["ProxyUse"]));
			}
			set {
				this["ProxyUse"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("")]
		public string ProxyUser {
			get {
				return ((string)(this["ProxyUser"]));
			}
			set {
				this["ProxyUser"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("False")]
		public bool UseThumbnailImages {
			get {
				return ((bool)(this["UseThumbnailImages"]));
			}
			set {
				this["UseThumbnailImages"] = value;
			}
		}
	}
}
