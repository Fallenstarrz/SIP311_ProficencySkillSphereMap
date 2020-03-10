using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProficiencySetup : MonoBehaviour
{

    [Header("Skill Name")]
    public Text skillNameText;
    [Header("Skill Icon")]
    public Image skillIcon;
    [Header("Skill Level")]
    public Text skillLevelText;
    [Header("Skill Experience")]
    public Image skillExpFillBar;
    [Header("Skill Points Available")]
    public Text pointsAvailableText;

    public void setupUI(string sName, int sLevel, int sExpMax, int sExpCur, int sPointsAvail, Sprite sSprite)
    {
        this.name = sName + " Proficiency Item";
        skillNameText.text = sName;
        skillIcon.sprite = sSprite;
        skillLevelText.text = sLevel.ToString();
        pointsAvailableText.text = sPointsAvail.ToString();
        skillExpFillBar.fillAmount = sExpCur / sExpMax;
    }
}
