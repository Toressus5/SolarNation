using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNewGame : MonoBehaviour
{
    public void NewGameButton()
    {
        PlayerPrefs.DeleteAll();
        StatsManager.Currency = 10;
        StatsManager.Environment = 0;
        StatsManager.AmountOfSolarPanels = 0;
        StatsManager.AmountOfWindTurbines = 0;
        StatsManager.AmountOfNuclearPlants= 0;
        StatsManager.AmountOfHydroStations= 0;
        StatsManager.AmountOfGasPlants= 0;
        StatsManager.AmountOfCoalPlants = 0;
        SceneManager.LoadScene("Game");
    }
}
