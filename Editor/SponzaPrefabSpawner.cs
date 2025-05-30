#if UNITY_EDITOR
using UnityEditor;

namespace UnityEssentials
{
    public static class SponzaPrefabSpawner
    {
        [MenuItem("GameObject/Essentials/Environments/Sponza", false, priority = 200)]
        private static void SpawnPrefab(MenuCommand menuCommand) =>
            ResourceLoaderEditor.InstantiatePrefab("UnityEssentials_Prefab_Sponza", "Sponza");
    }
}
#endif