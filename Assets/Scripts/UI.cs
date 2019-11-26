using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // This script takes care of all the UI buttons and texts
    public GameObject BuildingMenu;
    public GameObject BuildingMultiplier1;
    public GameObject BuildingMultiplier5;
    public GameObject BuildingMultiplier10;
    public GameObject BuildingMultiplier15;
    public GameObject BuildingMultiplier20;
    public GameObject BuildingMultiplier50;

    public GameObject UpgradesMenu;
    public GameObject AchievementsMenu;
    public GameObject HelpMenu;

    static public bool BuildingMenuActive = false;
    static public bool UpgradesMenuActive = false;
    static public bool AchievementsMenuActive = false;
    static public bool HelpMenuActive = false;

    public Text SolarDisplay;
    public Text WindDisplay;
    public Text CoalDisplay;
    public Text GasDisplay;
    public Text HydroDisplay;
    public Text NuclearDisplay;

    public void Update()
    {
        SolarDisplay.text = StatsManager.AmountOfSolarPanels + "";
        WindDisplay.text = StatsManager.AmountOfWindTurbines + "";
        CoalDisplay.text = StatsManager.AmountOfCoalPlants + "";
        GasDisplay.text = StatsManager.AmountOfGasPlants + "";
        HydroDisplay.text = StatsManager.AmountOfHydroStations + "";
        NuclearDisplay.text = StatsManager.AmountOfNuclearPlants + "";
    }

    public void PurchaseSolarPanelButton()
    {
        if (StatsManager.Currency >= CurrencyManager.CostOfSolarPanels * Building.BuildingAmount)
        {
            Building.PurchaseSolarPanel();
            CurrencyManager.CostOfSolarPanels = Mathf.Abs(CurrencyManager.CostOfSolarPanels * 1.05f);
           
        }
        if (TutorialScript.tutorialIndex == 3)
        {
            TutorialScript.tutorialIndex++;
        }

    }
    public void PurchaseWindTurbineButton()
    {
        if (StatsManager.Currency >= CurrencyManager.CostOfWindTurbines * Building.BuildingAmount)
        {
            Building.PurchaseWindTurbine();
            CurrencyManager.CostOfWindTurbines = Mathf.Abs(CurrencyManager.CostOfWindTurbines * 1.05f);
        }
        

    }
    public void PurchaseHydroStationButton()
    {
        if (StatsManager.Currency >= CurrencyManager.CostOfHydroStations * Building.BuildingAmount)
        {
            Building.PurchaseHydroStation();
            CurrencyManager.CostOfHydroStations = Mathf.Abs(CurrencyManager.CostOfHydroStations * 1.05f);
        }
        

    }
    public void PurchaseGasPlantButton()
    {
        if (StatsManager.Currency >= CurrencyManager.CostOfGasPlants * Building.BuildingAmount)
        {
            Building.PurchaseGasPlant();
            CurrencyManager.CostOfGasPlants = Mathf.Abs(CurrencyManager.CostOfGasPlants * 1.05f);
        }
        

    }
    public void PurchaseCoalPlantButton()
    {
        if (StatsManager.Currency >= CurrencyManager.CostOfCoalPlants * Building.BuildingAmount)
        {
            Building.PurchaseCoalPlant();
            CurrencyManager.CostOfCoalPlants = Mathf.Abs(CurrencyManager.CostOfCoalPlants * 1.05f);
        }
        
    }
    public void PurchaseNuclearPlantButton()
    {
        if (StatsManager.Currency >= CurrencyManager.CostOfNuclearPlants * Building.BuildingAmount)
        {
            Building.PurchaseNuclearPlant();
            CurrencyManager.CostOfNuclearPlants = Mathf.Abs(CurrencyManager.CostOfNuclearPlants * 1.05f);
        }
       
    }

    public void BuildingAmount1()
    {
        Building.BuildingAmount = 1;
        BuildingMultiplier1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        BuildingMultiplier5.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier10.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier15.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier20.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier50.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
    }
    public void BuildingAmount5()
    {
        Building.BuildingAmount = 5;
        BuildingMultiplier1.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        BuildingMultiplier10.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier15.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier20.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier50.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
    }
    public void BuildingAmount10()
    {
        Building.BuildingAmount = 10;
        BuildingMultiplier1.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier5.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        BuildingMultiplier15.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier20.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier50.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
    }
    public void BuildingAmount15()
    {
        Building.BuildingAmount = 15;
        BuildingMultiplier1.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier5.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier10.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        BuildingMultiplier20.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier50.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
    }
    public void BuildingAmount20()
    {
        Building.BuildingAmount = 20;
        BuildingMultiplier1.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier5.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier10.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier15.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        BuildingMultiplier50.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
    }
    public void BuildingAmount50()
    {
        Building.BuildingAmount = 50;
        BuildingMultiplier1.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier5.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier10.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier15.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier20.GetComponent<Image>().color = new Color32(111, 111, 111, 255);
        BuildingMultiplier50.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }

    public void Buildingmenu()
    {
        if (BuildingMenuActive == false)
        {
            BuildingMenu.SetActive(true);
            UpgradesMenu.SetActive(false);
            AchievementsMenu.SetActive(false);
            BuildingMenuActive = true;
            UpgradesMenuActive = false;
            AchievementsMenuActive = false;
            if (TutorialScript.tutorialIndex == 2)
            {
                TutorialScript.tutorialIndex++;
            }
        }
        else if (BuildingMenuActive == true)
        {
            BuildingMenu.SetActive(false);
            UpgradesMenu.SetActive(false);
            AchievementsMenu.SetActive(false);
            BuildingMenuActive = false;
            UpgradesMenuActive = false;
            AchievementsMenuActive = false;
        }
    }
    public void Upgradesmenu()
    {
        if (UpgradesMenuActive == false)
        {
            BuildingMenu.SetActive(false);
            UpgradesMenu.SetActive(true);
            AchievementsMenu.SetActive(false);
            BuildingMenuActive = false;
            UpgradesMenuActive = true;
            AchievementsMenuActive = false;
        }
        else if (UpgradesMenuActive == true)
        {
            BuildingMenu.SetActive(false);
            UpgradesMenu.SetActive(false);
            AchievementsMenu.SetActive(false);
            BuildingMenuActive = false;
            UpgradesMenuActive = false;
            AchievementsMenuActive = false;
        }
    }
    public void Achievementsmenu()
    {
        if (AchievementsMenuActive == false)
        {
            BuildingMenu.SetActive(false);
            UpgradesMenu.SetActive(false);
            AchievementsMenu.SetActive(true);
            BuildingMenuActive = false;
            UpgradesMenuActive = false;
            AchievementsMenuActive = true;
        }
        else if (AchievementsMenuActive == true)
        {
            BuildingMenu.SetActive(false);
            UpgradesMenu.SetActive(false);
            AchievementsMenu.SetActive(false);
            BuildingMenuActive = false;
            UpgradesMenuActive = false;
            AchievementsMenuActive = false;
        }
    }
    public void Helpmenu()
    {
        if (HelpMenuActive == false)
        {
            BuildingMenu.SetActive(false);
            UpgradesMenu.SetActive(false);
            AchievementsMenu.SetActive(false);
            BuildingMenuActive = false;
            UpgradesMenuActive = false;
            AchievementsMenuActive = false;
        }
        else if (HelpMenuActive == true)
        {
            BuildingMenu.SetActive(false);
            UpgradesMenu.SetActive(false);
            AchievementsMenu.SetActive(false);
            BuildingMenuActive = false;
            UpgradesMenuActive = false;
            AchievementsMenuActive = false;
        }
    }
}
