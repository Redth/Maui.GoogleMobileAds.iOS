# Version Header Diffs

This folder is intended to store the diffs between versions of the SDK.
There's a helper Makefile to try and generate the overall .diff file.

Eg:

```
make FROM_VERSION=11.1.0 TO_VERSION=11.2.0
```

This will attempt to look up the cocoapod spec file, extract the source / download URL from it, and then run a diff command between the headers, writing out a `FROM_VERSION-to-TO_VERSION.diff` file.

Each time the versions are changed, the PR author should generate and check in a new diff file here.
 