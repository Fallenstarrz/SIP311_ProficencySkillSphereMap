using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProficiencyTotals : MonoBehaviour
{
    public int m_TotalMax;
    public int m_TotalCurrent;
    public Text m_TotalsText;

    private void Start()
    {
        setCurrentSkillNumbers(m_TotalCurrent, m_TotalMax);
    }

    private void OnEnable()
    {
        // UI_ToggleProficency.OnToggleActiveEvent += swapSprite;
        // Subscribe to point spent event
    }

    private void OnDisable()
    {
        // UI_ToggleProficency.OnToggleActiveEvent -= swapSprite;
        // UnSubscribe to point spent event
    }

    private void setCurrentSkillNumbers(int current, int total)
    {
        m_TotalsText.text = current + " / " + total;
    }

    public void updateUI()
    {
        m_TotalsText.text = m_TotalCurrent + " / " + m_TotalMax;
    }

    public int getTotalMax()
    {
        return m_TotalMax;
    }
    public void setTotalMax(int newMax)
    {
        m_TotalMax = newMax;
    }
    public int getTotalCurrent()
    {
        return m_TotalCurrent;
    }
    public void setTotalCurrent(int newCurrent)
    {
        m_TotalCurrent = newCurrent;
    }

    public void modifyTotalMax(int amountToChange)
    {
        m_TotalMax += amountToChange;
    }
}
