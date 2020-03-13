using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ToggleProficency : MonoBehaviour
{
    public static event OnActiveEvent OnToggleActiveEvent;
    public delegate void OnActiveEvent(Sprite newSprite);

    // Change active skill map
    public void toggleActive()
    {
        GetComponentInParent<SkillMapCreator>().enableSkillTree(this.gameObject);
        changeActiveIcon();
    }

    // Send event to listeners that subscribe to OnToggleActiveEvent
    public void changeActiveIcon()
    {
        if (OnToggleActiveEvent != null)
        {
            OnToggleActiveEvent.Invoke(this.GetComponent<ProficiencySetup>().m_skillIcon.sprite); 
        }
    }
}