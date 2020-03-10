using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Map", menuName = "Skill Map")]
public class SkillsMap : ScriptableObject
{
    [Header("Skill Name")]
    public string skillName;
    [Header("Skill Icon")]
    public Sprite skillIcon;
    public Color skillIconColor = Color.white;
    [Header("Skill Background Texture")]
    public Sprite backgroundTexture;
    public Color backgroundTextureColor = Color.white;
    [Header("Skill Background Image")]
    public Sprite backgroundImg;
    public Color backgroundImgColor = Color.white;
    [Header("Skill Level")]
    public int skillLevelMax = 100;
    public int skillLevelCurrent = 0;
    [Header("Skill Experience")]
    public int skillExpMax = 100;
    public int skillExpCurrent = 0;
    [Header("Skill Points Available")]
    public int skillPointsAvailable = 0;
}
