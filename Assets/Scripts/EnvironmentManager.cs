using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    // this script calculates the amount of environmental damage the globe gets each game tick
    static public float EnvironmentIncrease;
    static public float EnvironmentDecrease = 0.3f;

    private float EnvironmentSolarPanels;
    private float EnvironmentWindTurbines;
    private float EnvironmentHydroStations;
    private float EnvironmentCoalPlants;
    private float EnvironmentGasPlants;
    private float EnvironmentNuclearPlants;

    [Header("How much each generator damages the environment")]
    public float EnvironmentValueOfSolarPanels;
    public float EnvironmentValueOfWindTurbines;
    public float EnvironmentValueOfHydroStations;
    public float EnvironmentValueOfCoalPlants;
    public float EnvironmentValueOfGasPlants;
    public float EnvironmentValueOfNuclearPlants;


    void Update()
    {
        EnvironmentIncrease = EnvironmentSolarPanels + EnvironmentWindTurbines + EnvironmentHydroStations + EnvironmentCoalPlants + EnvironmentGasPlants + EnvironmentNuclearPlants - EnvironmentDecrease;
        Mathf.Abs(EnvironmentIncrease);
        EnvironmentSolarPanels = (StatsManager.AmountOfSolarPanels * EnvironmentValueOfSolarPanels)/100;
        EnvironmentWindTurbines = (StatsManager.AmountOfWindTurbines * EnvironmentValueOfWindTurbines) / 100;
        EnvironmentHydroStations = (StatsManager.AmountOfHydroStations * EnvironmentValueOfHydroStations) / 100;
        EnvironmentCoalPlants = (StatsManager.AmountOfCoalPlants * EnvironmentValueOfCoalPlants) / 100 ;
        EnvironmentGasPlants = (StatsManager.AmountOfGasPlants * EnvironmentValueOfGasPlants) / 100;
        EnvironmentNuclearPlants = (StatsManager.AmountOfNuclearPlants * EnvironmentValueOfNuclearPlants) / 100;
    }
}
