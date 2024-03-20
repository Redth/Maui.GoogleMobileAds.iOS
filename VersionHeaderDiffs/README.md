# Version Header Diffs

This folder is intended to store the diffs between versions of the SDKs.
There's a helper `diff.ps1` powershell script to try and generate the overall .diff files.

Eg:

```pwsh
pwsh ./diff.ps1 `
  -FromGoogleMobileAdsVersion '11.1.0' `
  -ToGoogleMobileAdsVersion '11.2.0' `
  -FromUserMessagingPlatformVersion '2.2.0' `
  -ToUserMessagingPlatformVersion '2.3.0'
```

This will attempt to look up the cocoapod spec file, extract the source / download URL from it, and then run a diff command between the headers, writing out `FROM_VERSION-to-TO_VERSION.diff` files for each SDK.

Each time the versions are changed, the PR author should generate and check in a new diff file here.
 