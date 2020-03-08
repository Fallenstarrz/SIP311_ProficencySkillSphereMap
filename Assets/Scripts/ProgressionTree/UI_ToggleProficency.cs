using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ToggleProficency : MonoBehaviour
{
    public void toggleActive()
    {
        this.gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
