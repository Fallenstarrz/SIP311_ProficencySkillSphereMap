using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressSwitch : MonoBehaviour
{
    public Image upImage;
    public Image downImage;
    public Image lockedImage;

    // 0 = up
    // 1 = down
    // 2 = locked
    [SerializeField]
    int progressInt;

    void Start()
    {
        progressInt = 0;
        switchActiveProgression();
    }

    public void incrementProgressInt()
    {
        if (progressInt >= 2)
        {
            progressInt = 0;
        }
        else
        {
            progressInt++;
        }
        switchActiveProgression();
    }

    void switchActiveProgression()
    {
        switch (progressInt)
        {
            case 0:
                upImage.enabled = true;
                downImage.enabled = false;
                lockedImage.enabled = false;
                break;
            case 1:
                upImage.enabled = false;
                downImage.enabled = true;
                lockedImage.enabled = false;
                break;
            case 2:
                upImage.enabled = false;
                downImage.enabled = false;
                lockedImage.enabled = true;
                break;
            default:
                break;
        }
    }
}
