// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace RestFilesClient {
	
	
	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[MonoTouch.Foundation.Register("AppDelegate")]
	public partial class AppDelegate {
		
		private MonoTouch.UIKit.UIWindow __mt_window;
		
		private MonoTouch.UIKit.UITextView __mt_txtResults;
		
		private MonoTouch.UIKit.UITextField __mt_txtPath;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Export("getFilesAtPath:")]
		partial void getFilesAtPath (MonoTouch.UIKit.UIButton sender);

		[MonoTouch.Foundation.Export("getFilesAtPathAsync:")]
		partial void getFilesAtPathAsync (MonoTouch.UIKit.UIButton sender);

		[MonoTouch.Foundation.Connect("window")]
		private MonoTouch.UIKit.UIWindow window {
			get {
				this.__mt_window = ((MonoTouch.UIKit.UIWindow)(this.GetNativeField("window")));
				return this.__mt_window;
			}
			set {
				this.__mt_window = value;
				this.SetNativeField("window", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("txtResults")]
		private MonoTouch.UIKit.UITextView txtResults {
			get {
				this.__mt_txtResults = ((MonoTouch.UIKit.UITextView)(this.GetNativeField("txtResults")));
				return this.__mt_txtResults;
			}
			set {
				this.__mt_txtResults = value;
				this.SetNativeField("txtResults", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("txtPath")]
		private MonoTouch.UIKit.UITextField txtPath {
			get {
				this.__mt_txtPath = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("txtPath")));
				return this.__mt_txtPath;
			}
			set {
				this.__mt_txtPath = value;
				this.SetNativeField("txtPath", value);
			}
		}
	}
}