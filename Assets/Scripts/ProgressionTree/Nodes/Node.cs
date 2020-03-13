using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    public List<Node> connectedNodes = new List<Node>();
    public bool isActive;

    public Texture lineTexture;
    public Color lineColor;
    public Vector3 startPos;
    public Vector3 stopPos;

    Color defaultColor;
    Image buttonImage;

    // Use this for initialization
    void Start()
    {
        buttonImage = GetComponent<Image>();
        defaultColor = buttonImage.color;
    }

    public void connectNodes()
    {
        foreach (Node node in connectedNodes)
        {

        }
    }

    public void toggleActiveConnections()
    {
        if (isActive == false)
        {
            isActive = true;
            foreach (Node node in connectedNodes)
            {
                // Turn on the node
                node.GetComponent<Button>().interactable = true; 
            } 
        }
        else
        {
            isActive = false;
            foreach (Node node in connectedNodes)
            {
                // turn off the node if the node isn't currently active
                if (node.isActive == false)
                {
                    node.GetComponent<Button>().interactable = false; 
                }
            } 
        }
        colorSwap();
    }

    void colorSwap()
    {
        if (isActive == true)
        {
            buttonImage.color = Color.yellow;
        }
        else
        {
            buttonImage.color = defaultColor;
        }
    }

    // Editor tool to create node connected to this node
    // Also spawn a connection
#if UNITY_EDITOR
#endif
}
