//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace BPBinding {
	[Register("PrinterSDK", true)]
	public unsafe partial class PrinterSDK : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PrinterSDK");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PrinterSDK () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PrinterSDK (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PrinterSDK (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("beep")]
		[CompilerGenerated]
		public virtual void Beep ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("beep"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("beep"));
			}
		}
		
		[Export ("connectBT:")]
		[CompilerGenerated]
		public virtual void ConnectBT (Printer printer)
		{
			if (printer == null)
				throw new ArgumentNullException ("printer");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("connectBT:"), printer.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("connectBT:"), printer.Handle);
			}
		}
		
		[Export ("connectIP:")]
		[CompilerGenerated]
		public virtual bool ConnectIP (string ipAddress)
		{
			if (ipAddress == null)
				throw new ArgumentNullException ("ipAddress");
			var nsipAddress = NSString.CreateNative (ipAddress);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("connectIP:"), nsipAddress);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("connectIP:"), nsipAddress);
			}
			NSString.ReleaseNative (nsipAddress);
			
			return ret;
		}
		
		[Export ("cutPaper")]
		[CompilerGenerated]
		public virtual void CutPaper ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cutPaper"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cutPaper"));
			}
		}
		
		[Export ("disconnect")]
		[CompilerGenerated]
		public virtual void Disconnect ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disconnect"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disconnect"));
			}
		}
		
		[Export ("openCasher")]
		[CompilerGenerated]
		public virtual void OpenCasher ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("openCasher"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("openCasher"));
			}
		}
		
		[Export ("printCodeBar:type:")]
		[CompilerGenerated]
		public virtual void PrintCodeBar (string text, CodeBarType type)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = NSString.CreateNative (text);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("printCodeBar:type:"), nstext, (UInt32)type);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("printCodeBar:type:"), nstext, (UInt32)type);
			}
			NSString.ReleaseNative (nstext);
			
		}
		
		[Export ("printImage:")]
		[CompilerGenerated]
		public virtual void PrintImage (global::UIKit.UIImage image)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("printImage:"), image.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("printImage:"), image.Handle);
			}
		}
		
		[Export ("printQrCode:")]
		[CompilerGenerated]
		public virtual void PrintQrCode (string text)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = NSString.CreateNative (text);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("printQrCode:"), nstext);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("printQrCode:"), nstext);
			}
			NSString.ReleaseNative (nstext);
			
		}
		
		[Export ("printTestPaper")]
		[CompilerGenerated]
		public virtual void PrintTestPaper ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("printTestPaper"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("printTestPaper"));
			}
		}
		
		[Export ("printText:")]
		[CompilerGenerated]
		public virtual void PrintText (string text)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = NSString.CreateNative (text);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("printText:"), nstext);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("printText:"), nstext);
			}
			NSString.ReleaseNative (nstext);
			
		}
		
		[Export ("printTextImage:")]
		[CompilerGenerated]
		public virtual void PrintTextImage (string text)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = NSString.CreateNative (text);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("printTextImage:"), nstext);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("printTextImage:"), nstext);
			}
			NSString.ReleaseNative (nstext);
			
		}
		
		[Export ("scanPrintersWithCompletion:")]
		[CompilerGenerated]
		public unsafe virtual void ScanPrintersWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPrinterScanPrintersCallback))]PrinterScanPrintersCallback callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDPrinterScanPrintersCallback.Handler, callback);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("scanPrintersWithCompletion:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("scanPrintersWithCompletion:"), (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("selfTest")]
		[CompilerGenerated]
		public virtual void SelfTest ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("selfTest"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selfTest"));
			}
		}
		
		[Export ("sendHex:")]
		[CompilerGenerated]
		public virtual void SendHex (string hex)
		{
			if (hex == null)
				throw new ArgumentNullException ("hex");
			var nshex = NSString.CreateNative (hex);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendHex:"), nshex);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendHex:"), nshex);
			}
			NSString.ReleaseNative (nshex);
			
		}
		
		[Export ("setFontSizeMultiple:")]
		[CompilerGenerated]
		public virtual void SetFontSizeMultiple (global::System.nint multiple)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setFontSizeMultiple:"), multiple);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setFontSizeMultiple:"), multiple);
			}
		}
		
		[Export ("setPrintWidth:")]
		[CompilerGenerated]
		public virtual void SetPrintWidth (global::System.nint width)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setPrintWidth:"), width);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setPrintWidth:"), width);
			}
		}
		
		[Export ("stopScanPrinters")]
		[CompilerGenerated]
		public virtual void StopScanPrinters ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopScanPrinters"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopScanPrinters"));
			}
		}
		
		[CompilerGenerated]
		public static PrinterSDK DefaultPrinterSDK {
			[Export ("defaultPrinterSDK")]
			get {
				PrinterSDK ret;
				ret =  Runtime.GetNSObject<PrinterSDK> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("defaultPrinterSDK")));
				return ret;
			}
			
		}
		
	} /* class PrinterSDK */
}
