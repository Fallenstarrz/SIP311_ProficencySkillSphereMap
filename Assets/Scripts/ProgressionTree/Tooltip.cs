using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    public GameObject testObj;
    public GameObject testSpawn;

    public void showTooltip()
    {
        testSpawn = Instantiate(testObj, testObj.transform.position, testObj.transform.rotation);
        Debug.Log("Show Tooltip");
    }

    public void hideTooltip()
    {
        Destroy(testSpawn);
        Debug.Log("Hide Tooltip");
    }
}
