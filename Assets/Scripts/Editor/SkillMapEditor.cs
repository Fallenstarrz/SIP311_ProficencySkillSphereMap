using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SkillMapCreator))]
public class SkillMapEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        SkillMapCreator skillMap = (SkillMapCreator)target;


        if (GUILayout.Button("Generate New Skill Map"))
        {
            if (skillMap.myMap == null)
            {
                throw new System.Exception("No Scriptable Object Assigned");
            }
            if (skillMap.skillMapPrefab == null)
            {
                throw new System.Exception("No Skill Map Prefab Assigned");
            }
            if (skillMap.skillMapContainer == null)
            {
                throw new System.Exception("No Skill Map Container Assigned");
            }
            if (skillMap.proficiencyListPrefab == null)
            {
                throw new System.Exception("No Proficiency Prefab Assigned");
            }
            if (skillMap.proficiencyListContainer == null)
            {
                throw new System.Exception("No Proficiency Container Assigned");
            }
            skillMap.createNewSkillMap();
        }

        if (GUILayout.Button("Generate New Skill Map(s) From List"))
        {
            if (skillMap.myMaps.Count == 0)
            {
                throw new System.Exception("No Scriptable Objects Assigned In List");
            }
            if (skillMap.skillMapPrefab == null)
            {
                throw new System.Exception("No Skill Map Prefab Assigned");
            }
            if (skillMap.skillMapContainer == null)
            {
                throw new System.Exception("No Skill Map Container Assigned");
            }
            if (skillMap.proficiencyListPrefab == null)
            {
                throw new System.Exception("No Proficiency Prefab Assigned");
            }
            if (skillMap.proficiencyListContainer == null)
            {
                throw new System.Exception("No Proficiency Container Assigned");
            }
            skillMap.createNewSkillMapsFromList();
        }
    }
}
