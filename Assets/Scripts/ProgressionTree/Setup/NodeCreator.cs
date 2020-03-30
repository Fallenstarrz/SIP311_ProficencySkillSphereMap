using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(Node))]
public class NodeCreator : MonoBehaviour
{
#if UNITY_EDITOR
    public GameObject nodePrefab;
    public GameObject connectionPrefab;

    public void createNewNode()
    {
        Transform nodeContainer = GetComponentInParent<NodeSetup>().NodeContainer;
        Transform connectorContainer = GetComponentInParent<NodeSetup>().ConnectionContainer;

        // Create Node
        Node myNode = GetComponent<Node>();
        Node newNode = Instantiate(nodePrefab, nodeContainer).GetComponent<Node>();
        newNode.connectedNodes.Clear();
        myNode.connectedNodes.Add(newNode);
        newNode.connectedNodes.Add(myNode);

        // Create Connection
        // Setup inter-node lines
        NodeConnector newConnection = Instantiate(connectionPrefab, connectorContainer).GetComponent<NodeConnector>();
        newConnection.startPos = myNode.GetComponent<RectTransform>();
        newConnection.endPos = newNode.GetComponent<RectTransform>();

        Selection.activeObject = newNode.gameObject;
    } 
#endif
}
