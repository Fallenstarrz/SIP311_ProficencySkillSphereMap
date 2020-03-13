using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillMapSetup : MonoBehaviour
{
    SkillsMap m_SkillsMap;

    [Header("Skill Background Texture")]
    public Image skillBackgroundTexture;
    [Header("Skill Background Image")]
    public Image skillBackgroundImage;

    public void setupUI(SkillsMap newMap)
    {
        m_SkillsMap = newMap;
        this.name = m_SkillsMap + " Skill Map";
        skillBackgroundImage.sprite = m_SkillsMap.backgroundImg;
        skillBackgroundImage.color = m_SkillsMap.backgroundImgColor;
        skillBackgroundTexture.sprite = m_SkillsMap.backgroundTexture;
        skillBackgroundTexture.color = m_SkillsMap.backgroundTextureColor;
    }
}