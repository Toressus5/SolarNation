using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleObjects : MonoBehaviour
{
    public List<GameObject> solarPanels;
    public List<GameObject> windTurbines;
    public List<GameObject> nuclearPlants;
    public List<GameObject> gasPlants;
    public List<GameObject> coalPlants;
    public List<GameObject> hydroPlants;


    private int solarLenght = 3;
    private int activeSolars = 1;

    private int windLenght = 1;
    private int activeWind = 1;

    private int nuclearLenght = 1;
    private int activeNuclear = 1;

    private int gasLenght = 1;
    private int activeGas = 1;

    private int coalLenght = 1;
    private int activeCoal = 1;

    private int hydroLenght = 1;
    private int activeHydro = 1;

    void Start()
    {

    }

    void Update()
    {
        if (StatsManager.AmountOfSolarPanels == activeSolars)
        {
            for (int i = 0; i < solarLenght; i++)
            {
                if (solarPanels[i] != null)
                {
                    solarPanels[i].SetActive(true);

                }
            }
            activeSolars += 6;
            solarLenght += 3;
        }

        if (StatsManager.AmountOfWindTurbines == activeWind)
        {
            for (int i = 0; i < windLenght; i++)
            {
                if (windTurbines[i] != null)
                {
                    windTurbines[i].SetActive(true);

                }
            }
            activeWind += 2;
            windLenght += 1;
        }

        if (StatsManager.AmountOfNuclearPlants == activeNuclear)
        {
            for (int i = 0; i < nuclearLenght; i++)
            {
                if (nuclearPlants[i] != null)
                {
                    nuclearPlants[i].SetActive(true);

                }
            }
            activeNuclear += 1;
            nuclearLenght += 1;
        }

        if (StatsManager.AmountOfGasPlants == activeGas)
        {
            for (int i = 0; i < gasLenght; i++)
            {
                if (gasPlants[i] != null)
                {
                    gasPlants[i].SetActive(true);

                }
            }
            activeGas += 1;
            gasLenght += 1;
        }

        if (StatsManager.AmountOfCoalPlants == activeCoal)
        {
            for (int i = 0; i < coalLenght; i++)
            {
                if (coalPlants[i] != null)
                {
                    coalPlants[i].SetActive(true);

                }
            }
            activeCoal += 1;
            coalLenght += 1;
        }

        if (StatsManager.AmountOfHydroStations == activeHydro)
        {
            for (int i = 0; i < hydroLenght; i++)
            {
                if (hydroPlants[i] != null)
                {
                    hydroPlants[i].SetActive(true);

                }
            }
            activeHydro += 1;
            hydroLenght += 1;
        }
    }
}

