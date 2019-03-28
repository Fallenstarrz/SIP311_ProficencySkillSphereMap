using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ToggleProficency : MonoBehaviour
{
    bool isCurrentlyActive;

    private void Start()
    {

    }

    public void toggleActive()
    {
        if (isCurrentlyActive == false)
        {
            isCurrentlyActive = true;
        }
        else
        {
            isCurrentlyActive = false;
        }
        this.gameObject.SetActive(isCurrentlyActive);
    }
}
