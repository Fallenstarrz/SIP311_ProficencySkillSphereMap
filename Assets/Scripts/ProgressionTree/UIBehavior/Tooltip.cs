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
    }

    public void hideTooltip()
    {
        Destroy(testSpawn);
    }
}
