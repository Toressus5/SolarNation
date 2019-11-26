using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    // This script takes care of upgrades and the multipliers coming with it
    static public float totalUpgrades = 0;

    static public float SolarMultiplier = 1;
    static public float WindMultiplier = 1;
    static public float HydroMultiplier = 1;
    static public float CoalMultiplier = 1;
    static public float GasMultiplier = 1;
    static public float NuclearMultiplier = 1;

    static public float SolarUpgradeCost = 1000;
    static public float WindUpgradeCost = 10000;
    static public float HydroUpgradeCost = 100000000;
    static public float CoalUpgradeCost = 50000;
    static public float GasUpgradeCost = 900000;
    static public float NuclearUpgradeCost = 10000000;

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
    private void Update()
    {
        solarTemp.text = MoneyConverter.Instance.CurrencyToString(SolarUpgradeCost) + "$";
        windTemp.text = MoneyConverter.Instance.CurrencyToString(WindUpgradeCost) + "$";
        coalTemp.text = MoneyConverter.Instance.CurrencyToString(CoalUpgradeCost) + "$";
        gasTemp.text = MoneyConverter.Instance.CurrencyToString(GasUpgradeCost) + "$";
        nuclearTemp.text = MoneyConverter.Instance.CurrencyToString(NuclearUpgradeCost) + "$";
        hydroTemp.text = MoneyConverter.Instance.CurrencyToString(HydroUpgradeCost) + "$";
    }

    public void SolarMultiplierFunction()
    {
        if (StatsManager.Currency > SolarUpgradeCost)
        {
            SolarMultiplier++;
            StatsManager.Currency -= SolarUpgradeCost;
            float temp = Mathf.RoundToInt(SolarUpgradeCost * 2f);
            solarTemp.text = temp.ToString() + "$";
            SolarUpgradeCost = temp;
            totalUpgrades++;
        }
    }
    public void WindMultiplierFunction()
    {
        if (StatsManager.Currency > WindUpgradeCost)
        {
            WindMultiplier++;
            StatsManager.Currency -= WindUpgradeCost;
            float temp = Mathf.RoundToInt(WindUpgradeCost * 2f);
            windTemp.text = MoneyConverter.Instance.CurrencyToString(temp) + "$";
            WindUpgradeCost = temp;
            totalUpgrades++;
        }
    }
    public void HydroMultiplierFunction()
    {
        if (StatsManager.Currency > HydroUpgradeCost)
        {
            HydroMultiplier++;
            StatsManager.Currency -= HydroUpgradeCost;
            float temp = Mathf.RoundToInt(HydroUpgradeCost * 2f);
            hydroTemp.text = MoneyConverter.Instance.CurrencyToString(temp) + "$";
            HydroUpgradeCost = temp;
            totalUpgrades++;
        }
    }
    public void CoalMultiplierFunction()
    {
        if (StatsManager.Currency > CoalUpgradeCost)
        {
            CoalMultiplier++;
            StatsManager.Currency -= CoalUpgradeCost;
            float temp = Mathf.RoundToInt(CoalUpgradeCost * 2f);
            coalTemp.text = MoneyConverter.Instance.CurrencyToString(temp) + "$";
            CoalUpgradeCost = temp;
            totalUpgrades++;
        }
    }
    public void GasMultiplierFunction()
    {
        if (StatsManager.Currency > GasUpgradeCost)
        {
            GasMultiplier ++;
            StatsManager.Currency -= GasUpgradeCost;
            float temp = Mathf.RoundToInt(GasUpgradeCost * 2f);
            gasTemp.text = MoneyConverter.Instance.CurrencyToString(temp) + "$";
            GasUpgradeCost = temp;
            totalUpgrades++;

        }
    }
    public void NuclearMultiplierFunction()
    {
        if (StatsManager.Currency > NuclearUpgradeCost)
        {
            NuclearMultiplier++;
            StatsManager.Currency -= NuclearUpgradeCost;
            float temp = Mathf.RoundToInt(NuclearUpgradeCost * 2f);
            nuclearTemp.text = MoneyConverter.Instance.CurrencyToString(temp) + "$";
            NuclearUpgradeCost = temp;
            totalUpgrades++;
        }
    }
}
