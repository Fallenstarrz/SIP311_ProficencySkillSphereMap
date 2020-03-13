using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProficiencyTotals : MonoBehaviour
{
    public Image m_IconImg;
    public Text m_CurrentText;
    public Text m_TotalsText;

    private void OnEnable()
    {
        UI_ToggleProficency.OnToggleActiveEvent += swapSprite;
        // Subscribe to leveling event
        // Subscribe to point spent event
    }

    private void OnDisable()
    {
        UI_ToggleProficency.OnToggleActiveEvent -= swapSprite;
        // UnSubscribe to leveling event
        // UnSubscribe to point spent event
    }

    private void swapSprite(Sprite newSprite)
    {
        m_IconImg.sprite = newSprite;
    }
}
