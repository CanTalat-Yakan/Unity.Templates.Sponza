# Unity Essentials

This module is part of the Unity Essentials ecosystem and follows the same lightweight, editor-first approach.
Unity Essentials is a lightweight, modular set of editor utilities and helpers that streamline Unity development. It focuses on clean, dependency-free tools that work well together.

All utilities are under the `UnityEssentials` namespace.

```csharp
using UnityEssentials;
```

## Installation

Install the Unity Essentials entry package via Unity's Package Manager, then install modules from the Tools menu.

- Add the entry package (via Git URL)
    - Window → Package Manager
    - "+" → "Add package from git URL…"
    - Paste: `https://github.com/CanTalat-Yakan/UnityEssentials.git`

- Install or update Unity Essentials packages
    - Tools → Install & Update UnityEssentials
    - Install all or select individual modules; run again anytime to update

---

# Sponza

> Quick overview: One‑click Sponza environment prefab spawner. Adds a ready‑to‑use Sponza scene setup from `Resources` via the GameObject menu.

A tiny template module that drops the Sponza environment prefab into your current scene. It’s useful for quickly testing lighting, materials, cameras, and post‑processing without hunting for content.

![screenshot](Documentation/Screenshot.png)

## Features
- One‑click spawn from the main menu
  - GameObject → Essentials → Environments → Sponza
- Prefab‑based
  - Instantiates `Resources/UnityEssentials_Prefab_Sponza.prefab`
  - Names the created root “Sponza”
- Editor‑only helper
  - Simple and dependency‑light; no runtime components

## Requirements
- Unity 6000.0+
- Editor module; relies on the Sponza prefab shipped in this package’s `Resources`

## Usage
1) In the Hierarchy, select where you want the prefab (or nothing to place at the scene root)
2) Menu: GameObject → Essentials → Environments → Sponza
3) The `Sponza` prefab instance is created in the scene
4) Optional polish:
   - Add a Skybox/Environment Lighting if your project is empty
   - Add Reflection Probes or bake lighting for better results
   - Drop a camera in and frame your shot

Alternative: drag the prefab manually from the Project window
- Path: `Assets/Repositories/Unity.Templates.Sponza/Resources/UnityEssentials_Prefab_Sponza.prefab`

## How It Works
- The editor menu item calls a small helper that loads the prefab from `Resources` and instantiates it as a scene object:
  - `SponzaPrefabSpawner` → `ResourceLoaderEditor.InstantiatePrefab("UnityEssentials_Prefab_Sponza", "Sponza")`
- The created GameObject is named “Sponza”; parenting/position follow standard prefab instantiation conventions

## Notes and Limitations
- Rendering pipeline differences
  - Materials may look different depending on your project’s render pipeline and quality settings
  - If needed, run your pipeline’s material upgrade tools after importing this module
- Lighting and post‑processing are not auto‑configured; set these up to match your project
- The prefab is loaded from `Resources`; do not rename the file if you rely on the menu command

## Files in This Package
- `Editor/SponzaPrefabSpawner.cs` – Menu command to instantiate the Sponza prefab
- `Resources/UnityEssentials_Prefab_Sponza.prefab` – The environment prefab
- `Editor/UnityEssentials.Sponza.Editor.asmdef` – Editor assembly definition
- `package.json` – UPM package metadata

## Tags
unity, template, sponza, environment, scene, prefab, lighting, materials, editor, tools
