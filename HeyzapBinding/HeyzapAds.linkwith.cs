using ObjCRuntime;

[assembly: LinkWith ("HeyzapAds.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.ArmV7s,  SmartLink = true, ForceLoad = true, Frameworks = "AVFoundation Accelerate AudioToolbox CFNetwork EventKit EventKitUI CoreTelephony Foundation CoreGraphics SafariServices QuartzCore MobileCoreServices MediaPlayer MessageUI UIKit AdSupport iAd WebKit StoreKit Security SystemConfiguration", LinkerFlags = "-lz -lc++ -lxml2 -lsqlite3.0" )]