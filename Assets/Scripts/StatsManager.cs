using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour
{
    public GameObject Globe;
    public GameObject ExplosionEffect;
    // This script takes care of all the both holding and displaying of the currency and environment stat in the UI
    [Header("Stats")]
    static public float Currency = 10;
    [Range(0, 100)]
    static public float Environment = 0;



    static public float Day = 1;
    static public float Month = 1;
    static public float Year = 2019;

    static public float AmountOfSolarPanels;
    static public float AmountOfWindTurbines;
    static public float AmountOfHydroStations;
    static public float AmountOfCoalPlants;
    static public float AmountOfGasPlants;
    static public float AmountOfNuclearPlants;
    static public float AmountOfBuildings;

    public Text CurrencyDisplay;
    public Text EnvironmentDisplay;

    System.DateTime saved = new System.DateTime(1996, 6, 3, 22, 15, 0);
    System.DateTime current = System.DateTime.Now;

    public GameObject EndGame;

    void Start()
    {
        System.TimeSpan AFKProfit = current.Subtract(saved);
        InvokeRepeating("GameTick", 1f, 1f);

    }

    void Update()
    {
        if (Environment<0)
        {
            Environment = 0;
        }
        if (Environment >= 100)
        {
            EarthExplosion();
            Environment = 100;
        }
        CurrencyDisplay.text = "$" + Currency;
        EnvironmentDisplay.text = Environment + "%";
        CurrencyDisplay.text = "$" + MoneyConverter.Instance.CurrencyToString(Currency);
        AmountOfBuildings = AmountOfSolarPanels + AmountOfWindTurbines + AmountOfHydroStations + AmountOfCoalPlants + AmountOfGasPlants + AmountOfNuclearPlants;
    }

    void GameTick()
    {
        Currency += CurrencyManager.CurrencyIncrease;
        Environment += EnvironmentManager.EnvironmentIncrease;
    }

    void EarthExplosion()
    {
        bool exploded = false;
        if (exploded == false)
        {
            Instantiate(ExplosionEffect, Globe.transform.position, Globe.transform.rotation);
            Destroy(Globe);
            exploded = true;
            EndGame.SetActive(true);

            StartCoroutine("WaitSomeSeconds3", 3);
            
        }
        
    }

    IEnumerator WaitSomeSeconds(int seconds)
    {
        yield return new WaitForSeconds(seconds);

    }
}

