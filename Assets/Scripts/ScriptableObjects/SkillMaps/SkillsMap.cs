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
    public float skillExpMax = 100;
    public float skillExpCurrent = 0;
    [Header("Skill Points Available")]
    public int skillPointsAvailable = 0;
    public int skillPointsSpent = 0;

    // Toggle Status, Up, Down, Locked

    public ProficiencySetup m_Proficiency;
    public SkillMapSetup m_Map;

    /// <summary>
    /// Spend and Refund skills
    /// </summary>
    /// <param name="numPointsToSpend">Positive for increase, Negative for decrease</param>
    public void spendPoints(int numPointsToSpend)
    {
        if (skillPointsAvailable >= numPointsToSpend)
        {
            skillPointsAvailable -= numPointsToSpend;
            skillPointsSpent += numPointsToSpend;
            ProficiencyTotals totals = FindObjectOfType<ProficiencyTotals>();
            totals.setTotalCurrent(totals.getTotalCurrent() + numPointsToSpend);
            totals.updateUI();
        }
        else
        {
            Debug.Log("Not enough points");
        }
        m_Proficiency.updateUI();
    }

    /// <summary>
    /// Earn exp if not at level cap or would exceed level cap
    /// Then update UI
    /// </summary>
    /// <param name="expGained">Experience to gain</param>
    public void GainExp(float expGained)
    {
        if (checkLevelUp(expGained) == true)
        {
            skillExpCurrent = 0.0f;
            skillExpMax = Mathf.Floor(skillExpMax * 1.1f);
            skillLevelCurrent += 1;
            skillPointsAvailable += 1;

            m_Proficiency.updateUI();
        }
        else
        {
            if (skillExpCurrent + expGained > skillExpMax)
            {
                skillExpCurrent = skillExpMax - 1.0f;
                m_Proficiency.updateUI();
            }
            else
            {
                skillExpCurrent += expGained;
                m_Proficiency.updateUI();
            }
        }
    }

    /// <summary>
    /// Check to see if this skill can be leveled up
    /// </summary>
    /// <param name="expGained"></param>
    /// <returns></returns>
    public bool checkLevelUp(float expGained)
    {
        if ((skillExpCurrent + expGained) >= skillExpMax)
        {
            if (skillLevelCurrent < skillLevelMax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
