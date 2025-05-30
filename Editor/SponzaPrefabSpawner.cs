#if UNITY_EDITOR
using UnityEditor;

namespace UnityEssentials
{
    public static class SponzaPrefabSpawner
    {
        [MenuItem("GameObject/Essentials/Environments/Sponza", false, priority = 200)]
        private static void SpawnPrefab(MenuCommand menuCommand)
        {
            var prefab = ResourceLoaderEditor.InstantiatePrefab("UnityEssentials_Prefab_Sponza", "Sponza");

            PrefabUtility.UnpackPrefabInstance(prefab,
                PrefabUnpackMode.Completely,
                InteractionMode.AutomatedAction);
        }
    }
}
#endif