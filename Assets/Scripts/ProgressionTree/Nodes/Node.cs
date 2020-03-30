using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    public List<Node> connectedNodes = new List<Node>();
    public bool isActive;

    Color defaultColor;
    Image buttonImage;

    // Use this for initialization
    void Start()
    {
        foreach (Image image in GetComponentsInChildren<Image>())
        {
            if (image.gameObject.name == "NodeColor")
            {
                buttonImage = image;
            }
        }
        defaultColor = buttonImage.color;
    }

    public void toggleActiveConnections()
    {
        if (GetComponentInParent<SkillMapSetup>().m_SkillsMap.skillPointsAvailable > 0)
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
    }

    void colorSwap()
    {
        if (isActive == true)
        {
            buttonImage.color = Color.yellow;
            GetComponentInParent<SkillMapSetup>().m_SkillsMap.spendPoints(1);
        }
        else
        {
            buttonImage.color = defaultColor;
            GetComponentInParent<SkillMapSetup>().m_SkillsMap.spendPoints(-1);
        }
    }

    // Editor tool to create node connected to this node
    // Also spawn a connection
#if UNITY_EDITOR
#endif
}
