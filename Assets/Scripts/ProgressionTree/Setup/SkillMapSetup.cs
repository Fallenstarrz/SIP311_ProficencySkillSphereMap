using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillMapSetup : MonoBehaviour
{
    [Header("Skill Background Texture")]
    public Image skillBackgroundTexture;
    [Header("Skill Background Image")]
    public Image skillBackgroundImage;

    public void setupUI(string sName, Sprite bgImg, Color bgImgColor, Sprite bgTexture, Color bgTextureColor)
    {
        this.name = sName + " Skill Map";
        skillBackgroundImage.sprite = bgImg;
        skillBackgroundImage.color = bgImgColor;
        skillBackgroundTexture.sprite = bgTexture;
        skillBackgroundTexture.color = bgTextureColor;
    }
}
