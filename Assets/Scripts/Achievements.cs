using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    // this script holds all the achievements
    bool Money = false;
    bool FirstBuilding = false;
    bool FiveBuildings = false;
    bool FirstUpgrade = false;
    bool FiveUpgrades = false;

    public GameObject MoneyAchievement;
    public GameObject FirstBuildingAchievement;
    public GameObject FiveBuildingsAchievement;
    public GameObject FirstUpgradeAchievement;
    public GameObject FiveUpgradesAchievement;

    void Update()
    {
        if (StatsManager.Environment > 30 && Money == false)
        {
            Announcer.AnnounceText = "The globe is damage up to 30%";
        }
        if (StatsManager.Environment > 50 && Money == false)
        {
            Announcer.AnnounceText = "Carefull! The globe is damage over 50%";
        }
        if (StatsManager.Environment > 90 && Money == false)
        {
            Announcer.AnnounceText = "The globe is about to die! do something about it!";
        }

        if (StatsManager.AmountOfBuildings > 0 && FirstBuilding == false)
        {
            Announcer.AnnounceText = "Build your first building! achievement unlocked";
            FirstBuilding = true;
            FirstBuildingAchievement.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        if (StatsManager.AmountOfBuildings > 4 && FiveBuildings == false)
        {
            Announcer.AnnounceText = "Build 5 buildings! achievement unlocked";
            FiveBuildings = true;
            FiveBuildingsAchievement.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        if (Upgrades.totalUpgrades > 0 && FirstUpgrade == false)
        {
            Announcer.AnnounceText = "Your first upgrade! achievement unlocked";
            FirstUpgrade = true;
            FirstUpgradeAchievement.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        if (Upgrades.totalUpgrades > 4 && FiveUpgrades == false)
        {
            Announcer.AnnounceText = "You upgraded five times! achievement unlocked";
            FiveUpgrades = true;
            FiveUpgradesAchievement.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }


    }
}
