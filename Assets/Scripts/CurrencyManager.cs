using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyManager : MonoBehaviour
{
    // this script calculates the amount of currency the player earns each game tick
    static public float CurrencyIncrease;
    public Text increaseText;
    [Header("Public for testing purposes")]


    private float SolarPanels;
    private float WindTurbines;
    private float HydroStations;
    private float CoalPlants;
    private float GasPlants;
    private float NuclearPlants;

    [Header("How much each generator generates")]
    public static float ValueOfSolarPanels = 12;
    public static float ValueOfWindTurbines = 40;
    public static float ValueOfHydroStations = 90000;
    public static float ValueOfCoalPlants = 250;
    public static float ValueOfGasPlants = 250;
    public static float ValueOfNuclearPlants = 3500;

    [Header("How much each generator costs")]
    public static float CostOfSolarPanels = 100;
    public static float CostOfWindTurbines = 4000;
    public static float CostOfHydroStations = 10000000;
    public static float CostOfCoalPlants = 20000;
    public static float CostOfGasPlants = 300000;
    public static float CostOfNuclearPlants = 5000000;

    public static Text solarTemp;
    public Text SolarInspector;

    public static Text windTemp;
    public Text WindInspector;

    public static Text coalTemp;
    public Text CoalInspector;

    public static Text hydroTemp;
    public Text HydroInspector;

    public static Text nuclearTemp;
    public Text NuclearInspector;

    public static Text gasTemp;
    public Text GasInspector;

    private void Awake()
    {
        solarTemp = SolarInspector;
        gasTemp = GasInspector;
        nuclearTemp = NuclearInspector;
        coalTemp = CoalInspector;
        hydroTemp = HydroInspector;
        windTemp = WindInspector;

    }
    void Update()
    {
        solarTemp.text = MoneyConverter.Instance.CurrencyToString(CostOfSolarPanels) + "$";
        windTemp.text = MoneyConverter.Instance.CurrencyToString(CostOfWindTurbines) + "$";
        coalTemp.text = MoneyConverter.Instance.CurrencyToString(CostOfCoalPlants) + "$";
        gasTemp.text = MoneyConverter.Instance.CurrencyToString(CostOfGasPlants) + "$";
        nuclearTemp.text = MoneyConverter.Instance.CurrencyToString(CostOfNuclearPlants) + "$";
        hydroTemp.text = MoneyConverter.Instance.CurrencyToString(CostOfHydroStations) + "$";

        increaseText.text = MoneyConverter.Instance.CurrencyToString(CurrencyIncrease) + "/s";
        if (DayNight.day == false)
        {
            CurrencyIncrease = WindTurbines + HydroStations + CoalPlants + GasPlants + NuclearPlants;
        }
        if (DayNight.day == true)
        {
            CurrencyIncrease = SolarPanels + WindTurbines + HydroStations + CoalPlants + GasPlants + NuclearPlants;
        }
        
        SolarPanels = StatsManager.AmountOfSolarPanels * ValueOfSolarPanels * Upgrades.SolarMultiplier;
        WindTurbines = StatsManager.AmountOfWindTurbines * ValueOfWindTurbines * Upgrades.WindMultiplier;
        HydroStations = StatsManager.AmountOfHydroStations * ValueOfHydroStations * Upgrades.HydroMultiplier;
        CoalPlants = StatsManager.AmountOfCoalPlants * ValueOfCoalPlants * Upgrades.CoalMultiplier;
        GasPlants = StatsManager.AmountOfGasPlants * ValueOfGasPlants * Upgrades.GasMultiplier;
        NuclearPlants = StatsManager.AmountOfNuclearPlants * ValueOfNuclearPlants * Upgrades.NuclearMultiplier;
    }
}
