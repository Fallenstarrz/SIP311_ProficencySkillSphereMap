using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillMapCreator : MonoBehaviour
{
    public GameObject skillMapPrefab;
    public Transform skillMapContainer;
    public List<GameObject> skillMaps;

    [Header("Proficiencies List")]
    public GameObject proficiencyListPrefab;
    public Transform proficiencyListContainer;
    public float distanceBetweenProfListItems = -90f;
    public float FirstItemDistanceFromStartOfList = -50f;
    public List<GameObject> proficiencyListItems;

    [Header("Map Scriptable Object")]
    public SkillsMap myMap;
    public List<SkillsMap> myMaps;

    // Create object to represent the skill map and the proficiency list based on a the scriptable object myMap value
    public void createNewSkillMap()
    {
        {
            GameObject skillMap = Instantiate(skillMapPrefab, skillMapContainer);
            skillMaps.Add(skillMap);
            skillMap.GetComponent<SkillMapSetup>().setupUI(myMap);
            myMap.m_Map = GetComponent<SkillMapSetup>();
        }
        {
            GameObject proficiencyItem = Instantiate(proficiencyListPrefab, proficiencyListContainer);
            RectTransform profTf = proficiencyItem.GetComponent<RectTransform>();
            profTf.anchoredPosition = new Vector2(profTf.anchoredPosition.x, (FirstItemDistanceFromStartOfList + (proficiencyListItems.Count * distanceBetweenProfListItems)));
            proficiencyListItems.Add(proficiencyItem);
            proficiencyItem.GetComponent<ProficiencySetup>().SetupProficiency(myMap);
            myMap.m_Proficiency = proficiencyItem.GetComponent<ProficiencySetup>();
        }
        enableSkillTreeDefault();
    }

    // Create objects to represent the skill map and the proficiency list based on a the scriptable object myMaps list values
    public void createNewSkillMapsFromList()
    {
        foreach (SkillsMap map in myMaps)
        {
            {
                GameObject skillMap = Instantiate(skillMapPrefab, skillMapContainer);
                skillMaps.Add(skillMap);
                skillMap.GetComponent<SkillMapSetup>().setupUI(map);
                map.m_Map = skillMap.GetComponent<SkillMapSetup>();
            }
            {
                GameObject proficiencyItem = Instantiate(proficiencyListPrefab, proficiencyListContainer);
                RectTransform profTf = proficiencyItem.GetComponent<RectTransform>();
                profTf.anchoredPosition = new Vector2(profTf.anchoredPosition.x, (FirstItemDistanceFromStartOfList + (proficiencyListItems.Count * distanceBetweenProfListItems)));
                proficiencyListItems.Add(proficiencyItem);
                proficiencyItem.GetComponent<ProficiencySetup>().SetupProficiency(map);
                map.m_Proficiency = proficiencyItem.GetComponent<ProficiencySetup>();
            }
        }
        enableSkillTreeDefault();
    }

    // Enable and disable skill trees, so only 1 may be active at a time
    public void enableSkillTree(GameObject treeToEnable)
    {
        for (int i = 0; i < proficiencyListItems.Count; i++)
        {
            if (proficiencyListItems[i] == treeToEnable)
            {
                skillMaps[i].SetActive(true);
                continue;
            }
            else
            {
                skillMaps[i].SetActive(false);
            }
        }
    }

    // Set default skill tree on startup to map 0
    public void enableSkillTreeDefault()
    {
        skillMaps[0].SetActive(true);
        for (int i = 1; i < proficiencyListItems.Count; i++)
        {
                skillMaps[i].SetActive(false);
        }
    }
}