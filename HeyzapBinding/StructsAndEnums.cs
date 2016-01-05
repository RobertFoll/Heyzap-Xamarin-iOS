using System;
using ObjCRuntime;

namespace HeyzapBinding
{
	public enum HZDebugLevel : uint
	{
		Verbose = 3,
		Info = 2,
		Error = 1,
		Silent = 0
	}

	[Native]
	public enum HZBannerPosition :  long
	{
		Top,
		Bottom
	}

	[Native]
	public enum HZFacebookBannerSize : long
	{
		HZFacebookBannerSize320x50,
		FlexibleWidthHeight50,
		FlexibleWidthHeight90
	}

	[Native]
	public enum HZAdMobBannerSize : long
	{
		FlexibleWidthPortrait,
		FlexibleWidthLandscape,
		Banner,
		LargeBanner,
		Leaderboard,
		FullBanner
	}

	[Native]
	public enum HZAdOptions : long
	{
		None = 0 << 0,
		DisableAutoPrefetching = 1 << 0,
		InstallTrackingOnly = 1 << 1,
		AdvertiserOnly = InstallTrackingOnly,
		Amazon = 1 << 2,
		DisableMedation = 1 << 3,
		DisableAutomaticIAPRecording = 1 << 4
	}
}