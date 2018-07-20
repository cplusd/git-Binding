using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace BPBinding
{
[Static]
//[Verify(ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern NSString * PrinterConnectedNotification;
	[Field("PrinterConnectedNotification", "__Internal")]
	NSString PrinterConnectedNotification { get; }

	// extern NSString * PrinterDisconnectedNotification;
	[Field("PrinterDisconnectedNotification", "__Internal")]
	NSString PrinterDisconnectedNotification { get; }
}

// typedef void (^PrinterScanPrintersCallback)(Printer *);
delegate void PrinterScanPrintersCallback(Printer arg0);

// @interface Printer : NSObject
[BaseType(typeof(NSObject))]
interface Printer
{
	// @property (readonly, nonatomic) NSString * name;
	[Export("name")]
	string Name { get; }

	// @property (readonly, nonatomic) NSString * UUIDString;
	[Export("UUIDString")]
	string UUIDString { get; }
}

// @interface PrinterSDK : NSObject
[BaseType(typeof(NSObject))]
interface PrinterSDK
{
	// +(PrinterSDK *)defaultPrinterSDK;
	[Static]
	[Export("defaultPrinterSDK")]
	//[Verify(MethodToProperty)]
	PrinterSDK DefaultPrinterSDK { get; }

	// -(void)scanPrintersWithCompletion:(PrinterScanPrintersCallback)callback;
	[Export("scanPrintersWithCompletion:")]
	void ScanPrintersWithCompletion(PrinterScanPrintersCallback callback);

	// -(void)stopScanPrinters;
	[Export("stopScanPrinters")]
	void StopScanPrinters();

	// -(BOOL)connectIP:(NSString *)ipAddress;
	[Export("connectIP:")]
	bool ConnectIP(string ipAddress);

	// -(void)connectBT:(Printer *)printer;
	[Export("connectBT:")]
	void ConnectBT(Printer printer);

	// -(void)disconnect;
	[Export("disconnect")]
	void Disconnect();

	// -(void)setPrintWidth:(NSInteger)width;
	[Export("setPrintWidth:")]
	void SetPrintWidth(nint width);

	// -(void)printText:(NSString *)text;
	[Export("printText:")]
	void PrintText(string text);

	// -(void)printTextImage:(NSString *)text;
	[Export("printTextImage:")]
	void PrintTextImage(string text);

	// -(void)sendHex:(NSString *)hex;
	[Export("sendHex:")]
	void SendHex(string hex);

	// -(void)printCodeBar:(NSString *)text type:(CodeBarType)type;
	[Export("printCodeBar:type:")]
	void PrintCodeBar(string text, CodeBarType type);

	// -(void)printQrCode:(NSString *)text;
	[Export("printQrCode:")]
	void PrintQrCode(string text);

	// -(void)printImage:(UIImage *)image;
	[Export("printImage:")]
	void PrintImage(UIImage image);

	// -(void)cutPaper;
	[Export("cutPaper")]
	void CutPaper();

	// -(void)beep;
	[Export("beep")]
	void Beep();

	// -(void)openCasher;
	[Export("openCasher")]
	void OpenCasher();

	// -(void)setFontSizeMultiple:(NSInteger)multiple;
	[Export("setFontSizeMultiple:")]
	void SetFontSizeMultiple(nint multiple);

	// -(void)printTestPaper;
	[Export("printTestPaper")]
	void PrintTestPaper();

	// -(void)selfTest;
	[Export("selfTest")]
	void SelfTest();
}

}




