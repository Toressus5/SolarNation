using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    static public float BuildingAmount = 1;
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

    static public void PurchaseSolarPanel()
    {
        
        if (StatsManager.Currency >= CurrencyManager.CostOfSolarPanels * BuildingAmount)
        {
            print("work");
            StatsManager.AmountOfSolarPanels += 1 * BuildingAmount;
            StatsManager.Currency -= CurrencyManager.CostOfSolarPanels * BuildingAmount;
            float temp = Mathf.RoundToInt(CurrencyManager.CostOfSolarPanels * 1.05f);
            solarTemp.text = temp.ToString() + "$";
            CurrencyManager.CostOfSolarPanels = temp;
        }
    }
    static public void PurchaseWindTurbine()
    {
        if (StatsManager.Currency > CurrencyManager.CostOfWindTurbines * BuildingAmount)
        {
            StatsManager.AmountOfWindTurbines += 1 * BuildingAmount;
            StatsManager.Currency -= CurrencyManager.CostOfWindTurbines * BuildingAmount;
            float temp = Mathf.RoundToInt(CurrencyManager.CostOfWindTurbines * 1.05f);
            windTemp.text = temp.ToString() + "$";
            CurrencyManager.CostOfWindTurbines = temp;
        }
    }
    static public void PurchaseHydroStation()
    {
        if (StatsManager.Currency > CurrencyManager.CostOfHydroStations * BuildingAmount)
        {
            StatsManager.AmountOfHydroStations += 1 * BuildingAmount;
            StatsManager.Currency -= CurrencyManager.CostOfHydroStations * BuildingAmount;
            float temp = Mathf.RoundToInt(CurrencyManager.CostOfHydroStations * 1.05f);
            hydroTemp.text = temp.ToString() + "$";
            CurrencyManager.CostOfHydroStations = temp;
        }
    }
    static public void PurchaseGasPlant()
    {
        if (StatsManager.Currency > CurrencyManager.CostOfGasPlants * BuildingAmount)
        {
            StatsManager.AmountOfGasPlants += 1 * BuildingAmount;
            StatsManager.Currency -= CurrencyManager.CostOfGasPlants * BuildingAmount;
            float temp = Mathf.RoundToInt(CurrencyManager.CostOfGasPlants * 1.05f);
            gasTemp.text = temp.ToString() + "$";
            CurrencyManager.CostOfGasPlants = temp;
        }
    }
    static public void PurchaseCoalPlant()
    {
        if (StatsManager.Currency > CurrencyManager.CostOfCoalPlants * BuildingAmount)
        {
            StatsManager.AmountOfCoalPlants += 1 * BuildingAmount;
            StatsManager.Currency -= CurrencyManager.CostOfCoalPlants * BuildingAmount;
            float temp = Mathf.RoundToInt(CurrencyManager.CostOfCoalPlants * 1.05f);
            coalTemp.text = temp.ToString() + "$";
            CurrencyManager.CostOfCoalPlants = temp;
        }
    }

    static public void PurchaseNuclearPlant()
    {
        if (StatsManager.Currency > CurrencyManager.CostOfNuclearPlants * BuildingAmount)
        {
            StatsManager.AmountOfNuclearPlants += 1 * BuildingAmount;
            StatsManager.Currency -= CurrencyManager.CostOfNuclearPlants * BuildingAmount;
            float temp = Mathf.RoundToInt(CurrencyManager.CostOfNuclearPlants * 1.05f);
            nuclearTemp.text = temp.ToString() + "$";
            CurrencyManager.CostOfNuclearPlants = temp;
        }
    }
}
