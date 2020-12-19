# UGCTechDemo
A tech demo for user-generated content management in Unity. We'll refer to UGC as addons, since they add features rather than modify the game.

## Goals
- [ ] Runtime asset importing. This could be either local files (FBX, PNG, JPG, OBJ, etc.) or AssetBundles (rather than patching game files)
- [ ] In-editor addon creation
- [ ] File register to manage allowed asset formats
- [ ] Addon manager with a user interface
- [ ] Git support to download addons

## Risks
- Supporting Unity-specific files and C# could introduce a security risk, unless the addons are imported into a sandboxed environment (like a custom script interpreter or a C# library with limited functionality)
