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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::BPBinding.PrinterScanPrintersCallback))]
		internal delegate void DPrinterScanPrintersCallback (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPrinterScanPrintersCallback {
			static internal readonly DPrinterScanPrintersCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPrinterScanPrintersCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::BPBinding.PrinterScanPrintersCallback) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<BPBinding.Printer> (arg0));
			}
		} /* class SDPrinterScanPrintersCallback */
		
		internal class NIDPrinterScanPrintersCallback {
			IntPtr blockPtr;
			DPrinterScanPrintersCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPrinterScanPrintersCallback (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPrinterScanPrintersCallback> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPrinterScanPrintersCallback ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::BPBinding.PrinterScanPrintersCallback Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::BPBinding.PrinterScanPrintersCallback;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPrinterScanPrintersCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::BPBinding.Printer arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPrinterScanPrintersCallback */
	}
}
