using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MenuManager.isLoading)
        {
            StatsManager.Environment = PlayerPrefs.GetFloat("EnvironmentDamage");
            StatsManager.Currency = PlayerPrefs.GetFloat("Money");
            StatsManager.AmountOfCoalPlants = PlayerPrefs.GetFloat("CoalPlants");
            StatsManager.AmountOfGasPlants = PlayerPrefs.GetFloat("GasPlants");
            StatsManager.AmountOfHydroStations = PlayerPrefs.GetFloat("HydroStations");
            StatsManager.AmountOfNuclearPlants = PlayerPrefs.GetFloat("NuclearPlants");
            StatsManager.AmountOfSolarPanels = PlayerPrefs.GetFloat("SolarPanels");
            StatsManager.AmountOfWindTurbines = PlayerPrefs.GetFloat("WindTurbines");
            TimeScript.time = PlayerPrefs.GetString("LastTimeOnline");
            TutorialScript.TutorialOn = PlayerPrefs.GetFloat("Tutorial");
            MenuManager.isLoading = false;
        }
    }
}
