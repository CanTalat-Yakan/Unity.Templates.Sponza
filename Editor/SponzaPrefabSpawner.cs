#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace UnityEssentials
{
    public static class SponzaPrefabSpawner
    {
        [MenuItem("GameObject/3D Object/Sponza", false)]
        private static void SpawnPrefab(MenuCommand menuCommand)
        {
            var guids = AssetDatabase.FindAssets("Sponza t:Prefab");
            if (guids.Length == 0)
            {
                Debug.LogError("Sponza prefab not found in project.");
                return;
            }

            var path = AssetDatabase.GUIDToAssetPath(guids[0]);
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            if (prefab == null)
            {
                Debug.LogError($"Failed to load prefab at: {path}");
                return;
            }

            GameObject instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
            if (menuCommand.context is GameObject parent)
                GameObjectUtility.SetParentAndAlign(instance, parent);

            Undo.RegisterCreatedObjectUndo(instance, "Spawn " + instance.name);
            Selection.activeObject = instance;
        }
    }
}
#endif