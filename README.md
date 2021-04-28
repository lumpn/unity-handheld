# unity-handheld
Fixes missing Handheld class on Windows.

# Problem
Making a build for Windows while using `UnityEngine.Handheld` results in the following compiler error.

```csharp
error CS0103: The name 'Handheld' does not exist in the current context
```

The `Handheld` class, despite being in the global `UnityEngine` namespace, is only implemented for mobile platforms and the Unity editor.

# Solution
This package provides stubs for all methods in the `Handheld` class for the following platforms:
- WebGL
- Windows 32-bit
- Windows 64-bit

# Notes
It is unclear to me which platforms support `Handheld` by default. The above list of additional platforms is probably incomplete. If you need the stubs on another platform, please let me know.
