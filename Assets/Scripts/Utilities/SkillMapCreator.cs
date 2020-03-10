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

    public void createNewSkillMap()
    {

        {
            GameObject skillMap = Instantiate(skillMapPrefab, skillMapContainer);
            skillMaps.Add(skillMap);
            skillMap.GetComponent<SkillMapSetup>().setupUI(myMap.skillName, myMap.backgroundImg, myMap.backgroundImgColor, myMap.backgroundTexture, myMap.backgroundTextureColor);
        }
        {
            GameObject proficiencyItem = Instantiate(proficiencyListPrefab, proficiencyListContainer);
            RectTransform profTf = proficiencyItem.GetComponent<RectTransform>();
            profTf.anchoredPosition = new Vector2(profTf.anchoredPosition.x, (FirstItemDistanceFromStartOfList + (proficiencyListItems.Count * distanceBetweenProfListItems)));
            proficiencyListItems.Add(proficiencyItem);
            proficiencyItem.GetComponent<ProficiencySetup>().setupUI(myMap.skillName, myMap.skillLevelCurrent, myMap.skillExpMax, myMap.skillExpCurrent, myMap.skillPointsAvailable, myMap.skillIcon);
        }
    }

    public void createNewSkillMapsFromList()
    {
        foreach (SkillsMap map in myMaps)
        {
            {
                GameObject skillMap = Instantiate(skillMapPrefab, skillMapContainer);
                skillMaps.Add(skillMap);
                skillMap.GetComponent<SkillMapSetup>().setupUI(map.skillName, map.backgroundImg, map.backgroundImgColor, map.backgroundTexture, map.backgroundTextureColor);
            }
            {
                GameObject proficiencyItem = Instantiate(proficiencyListPrefab, proficiencyListContainer);
                RectTransform profTf = proficiencyItem.GetComponent<RectTransform>();
                profTf.anchoredPosition = new Vector2(profTf.anchoredPosition.x, (FirstItemDistanceFromStartOfList + (proficiencyListItems.Count * distanceBetweenProfListItems)));
                proficiencyListItems.Add(proficiencyItem);
                proficiencyItem.GetComponent<ProficiencySetup>().setupUI(map.skillName, map.skillLevelCurrent, map.skillExpMax, map.skillExpCurrent, map.skillPointsAvailable, map.skillIcon);
            }
        }
    }

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
}