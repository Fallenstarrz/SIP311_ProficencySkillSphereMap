using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressSwitch : MonoBehaviour
{
    public List<Sprite> sprites = new List<Sprite>();
    private Image img;

    // 0 = up
    // 1 = down
    // 2 = locked
    [SerializeField]
    int progressInt;
    [SerializeField]
    enum EProgressState
    {
        up,
        down,
        locked
    }
    EProgressState ECurrentProgressState;

    void Start()
    {
        progressInt = 0;
        img = GetComponent<Image>();
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
        ECurrentProgressState = (EProgressState)progressInt;
        switch (ECurrentProgressState)
        {
            case EProgressState.up:
                img.sprite = sprites[0];
                break;
            case EProgressState.down:
                img.sprite = sprites[1];
                break;
            case EProgressState.locked:
                img.sprite = sprites[2];
                break;
            default:
                break;
        }
    }
}
