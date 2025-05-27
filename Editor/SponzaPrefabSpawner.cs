#if UNITY_EDITOR
using UnityEditor;

namespace UnityEssentials
{
    public static class SponzaPrefabSpawner
    {
        [MenuItem("GameObject/Environment/Sponza", false)]
        private static void SpawnPrefab(MenuCommand menuCommand) =>
            ResourceLoaderEditor.InstantiatePrefab("UnityEssentials_Prefab_Sponza", "Sponza");
    }
}
#endif