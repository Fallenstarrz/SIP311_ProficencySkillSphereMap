using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NodeCreator))]
public class NodeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        NodeCreator node = (NodeCreator)target;

        if (GUILayout.Button("Create New Node"))
        {
            node.createNewNode();
        }
    }
}
