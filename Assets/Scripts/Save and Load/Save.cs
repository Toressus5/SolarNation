using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    private void Start()
    {
        InvokeRepeating("SaveGame", 10f, 10f);
    }
    public void SaveGame()
    {
        Debug.Log("Autosave");
        PlayerPrefs.SetFloat("EnvironmentDamage", StatsManager.Environment);
        PlayerPrefs.SetFloat("Money", StatsManager.Currency);
        PlayerPrefs.SetFloat("SolarPanels", StatsManager.AmountOfSolarPanels);
        PlayerPrefs.SetFloat("GasPlants", StatsManager.AmountOfGasPlants);
        PlayerPrefs.SetFloat("CoalPlants", StatsManager.AmountOfCoalPlants);
        PlayerPrefs.SetFloat("HydroStations", StatsManager.AmountOfHydroStations);
        PlayerPrefs.SetFloat("NuclearPlants", StatsManager.AmountOfNuclearPlants);
        PlayerPrefs.SetFloat("WindTurbines", StatsManager.AmountOfWindTurbines);
        PlayerPrefs.SetString ("LastTimeOnline", TimeScript.time);
        PlayerPrefs.SetFloat("Tutorial", TutorialScript.TutorialOn);
    }

}
