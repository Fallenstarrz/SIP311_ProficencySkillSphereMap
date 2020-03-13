using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProficiencySetup : MonoBehaviour
{
    public SkillsMap m_SkillMap;

    [Header("Skill Name")]
    public Text m_skillNameText;
    [Header("Skill Icon")]
    public Image m_skillIcon;
    [Header("Skill Level")]
    public Text m_skillLevelText;
    [Header("Skill Experience")]
    public Image m_skillExpFillBar;
    [Header("Skill Points Available")]
    public Text m_pointsAvailableText;
    [HideInInspector]
    public int m_levelMax;

    /// <summary>
    /// Setup Reference to the skill map assigned to this object
    /// </summary>
    /// <param name="newMap"></param>
    public void SetupProficiency(SkillsMap newMap)
    {
        m_SkillMap = newMap;
        setupUI();
    }

    private void Start()
    {
        setupUI();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha0))
        {
            m_SkillMap.GainExp(100.0f);
        }
    }

    /// <summary>
    /// Initial setup of UI when created
    /// </summary>
    public void setupUI()
    {
        this.name = m_SkillMap.skillName + " Proficiency Item";
        m_skillNameText.text = m_SkillMap.skillName;
        m_skillIcon.sprite = m_SkillMap.skillIcon;
        m_skillLevelText.text = m_SkillMap.skillLevelCurrent.ToString();
        m_pointsAvailableText.text = m_SkillMap.skillPointsAvailable.ToString();
        m_skillExpFillBar.fillAmount = m_SkillMap.skillExpCurrent / m_SkillMap.skillExpMax;
    }

    /// <summary>
    /// Update UI with new data
    /// </summary>
    public void updateUI()
    {
        m_skillLevelText.text = m_SkillMap.skillLevelCurrent.ToString();
        m_pointsAvailableText.text = m_SkillMap.skillPointsAvailable.ToString();
        m_skillExpFillBar.fillAmount = m_SkillMap.skillExpCurrent / m_SkillMap.skillExpMax;
    }
}