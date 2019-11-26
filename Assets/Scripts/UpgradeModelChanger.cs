using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeModelChanger : MonoBehaviour
{
    public List<GameObject> solarPanels;
    public List<GameObject> solarPanels2;
    public List<GameObject> solarPanels3;
    public List<GameObject> solarPanels4;
    private int SolarLevel = 5;

    public List<GameObject> windTurbines;
    public List<GameObject> windTurbines2;
    public List<GameObject> windTurbines3;
    public List<GameObject> windTurbines4;
    private int WindLevel = 5;

    public List<GameObject> nuclearPlants1;
    public List<GameObject> nuclearPlants2;
    public List<GameObject> nuclearPlants3;
    public List<GameObject> nuclearPlants4;
    private int NuclearLevel = 5;

    public List<GameObject> gasPlants;
    public List<GameObject> gasPlants2;
    public List<GameObject> gasPlants3;
    public List<GameObject> gasPlants4;

    public List<GameObject> coalPlants;
    public List<GameObject> coalPlants2;
    public List<GameObject> coalPlants3;
    public List<GameObject> coalPlants4;
    private int CoalLevel = 5;

    public List<GameObject> hydroPlants;
    public List<GameObject> hydroPlants2;
    public List<GameObject> hydroPlants3;
    public List<GameObject> hydroPlants4;
    private int HydroLevel = 5;

    private void Start()
    {
        //making higher level models to appear in 1st level model posiion
        
    }
    // Update is called once per frame
    void Update()
    {
        //solar
        for (int i = 0; i < 10; i++)
        {
                var firstLevelPosition = solarPanels[i].GetComponent<Transform>();

                solarPanels2[i].GetComponent<Transform>().position = firstLevelPosition.position;
                solarPanels2[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;

                solarPanels3[i].GetComponent<Transform>().position = firstLevelPosition.position;
                solarPanels3[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;

                solarPanels4[i].GetComponent<Transform>().position = firstLevelPosition.position;
                solarPanels4[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;
        }
        //wind
        for (int i = 0; i < 4; i++)
        {
            var firstLevelPosition = windTurbines[i].GetComponent<Transform>();

            windTurbines2[i].GetComponent<Transform>().position = firstLevelPosition.position;
            windTurbines2[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;

            windTurbines3[i].GetComponent<Transform>().position = firstLevelPosition.position;
            windTurbines3[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;

            windTurbines4[i].GetComponent<Transform>().position = firstLevelPosition.position;
            windTurbines4[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;
        }
        //nuclear
        for (int i = 0; i < 3; i++)
        {
            var firstLevelPosition = nuclearPlants1[i].GetComponent<Transform>();

            nuclearPlants2 [i].GetComponent<Transform>().position = firstLevelPosition.position;
            nuclearPlants2[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;

            nuclearPlants3[i].GetComponent<Transform>().position = firstLevelPosition.position;
            nuclearPlants3[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;

            nuclearPlants4[i].GetComponent<Transform>().position = firstLevelPosition.position;
            nuclearPlants4[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;
        }
        //coal
        for (int i = 0; i < 4; i++)
        {
            var firstLevelPosition = coalPlants[i].GetComponent<Transform>();

            coalPlants2[i].GetComponent<Transform>().position = firstLevelPosition.position;
            coalPlants2[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;

            coalPlants3[i].GetComponent<Transform>().position = firstLevelPosition.position;
            coalPlants3[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;

            coalPlants4[i].GetComponent<Transform>().position = firstLevelPosition.position;
            coalPlants4[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;
        }
        //hydro
        for (int i = 0; i < 2; i++)
        {
            var firstLevelPosition = hydroPlants[i].GetComponent<Transform>();

            hydroPlants2[i].GetComponent<Transform>().position = firstLevelPosition.position;
            hydroPlants2[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;

            hydroPlants3[i].GetComponent<Transform>().position = firstLevelPosition.position;
            hydroPlants3[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;

            hydroPlants4[i].GetComponent<Transform>().position = firstLevelPosition.position;
            hydroPlants4[i].GetComponent<Transform>().rotation = firstLevelPosition.rotation;
        }


        if (Upgrades.SolarMultiplier == SolarLevel)
        {
            SolarUpgrader();
        }
        if (Upgrades.CoalMultiplier == CoalLevel)
        {
            CoalUpgrader();
        }
        if (Upgrades.HydroMultiplier == HydroLevel)
        {
            HydroUpgrader();
        }
        if (Upgrades.NuclearMultiplier == NuclearLevel)
        {
            NuclearUpgrader();
        }
        if (Upgrades.WindMultiplier == WindLevel)
        {
            WindUpgrader();
        }
    }

    private void SolarUpgrader()
    {
        for (int i = 0; i < 10; i++)
        {
            if (solarPanels[i].activeInHierarchy == true && SolarLevel == 5)
            {
                solarPanels[i].SetActive(false);
                solarPanels2[i].SetActive(true);
                
            }
            if (solarPanels2[i].activeInHierarchy == true && SolarLevel == 10)
            {
                solarPanels2[i].SetActive(false);
                solarPanels3[i].SetActive(true);
                
            }
            if (solarPanels3[i].activeInHierarchy == true && SolarLevel == 15)
            {
                solarPanels3[i].SetActive(false);
                solarPanels4[i].SetActive(true);
            }
        }
        SolarLevel += 5;
    }
    private void WindUpgrader()
    {
        for (int i = 0; i < 4; i++)
        {
            if (windTurbines[i].activeInHierarchy == true && WindLevel == 5)
            {
                windTurbines[i].SetActive(false);
                windTurbines2[i].SetActive(true);

            }
            if (windTurbines2[i].activeInHierarchy == true && WindLevel == 10)
            {
                windTurbines2[i].SetActive(false);
                windTurbines3[i].SetActive(true);

            }
            if (windTurbines3[i].activeInHierarchy == true && WindLevel == 15)
            {
                windTurbines3[i].SetActive(false);
                windTurbines4[i].SetActive(true);
            }
        }
        WindLevel += 5;
    }
    private void HydroUpgrader()
    {
        for (int i = 0; i < 2; i++)
        {
            if (hydroPlants[i].activeInHierarchy == true && HydroLevel == 5)
            {
                hydroPlants[i].SetActive(false);
                hydroPlants2[i].SetActive(true);

            }
            if (hydroPlants2[i].activeInHierarchy == true && HydroLevel == 10)
            {
                hydroPlants2[i].SetActive(false);
                hydroPlants3[i].SetActive(true);

            }
            if (hydroPlants3[i].activeInHierarchy == true && HydroLevel == 15)
            {
                hydroPlants3[i].SetActive(false);
                hydroPlants4[i].SetActive(true);
            }
        }
        HydroLevel += 5;
    }
    private void NuclearUpgrader()
    {
        for (int i = 0; i < 3; i++)
        {
            if (nuclearPlants1[i].activeInHierarchy == true && NuclearLevel == 5)
            {
                nuclearPlants1[i].SetActive(false);
                nuclearPlants2[i].SetActive(true);

            }
            if (nuclearPlants2[i].activeInHierarchy == true && NuclearLevel == 10)
            {
                nuclearPlants2[i].SetActive(false);
                nuclearPlants3[i].SetActive(true);

            }
            if (nuclearPlants3[i].activeInHierarchy == true && NuclearLevel == 15)
            {
                nuclearPlants3[i].SetActive(false);
                nuclearPlants4[i].SetActive(true);
            }
        }
        NuclearLevel += 5;
    }
    private void CoalUpgrader()
    {
        for (int i = 0; i < 4; i++)
        {
            if (coalPlants[i].activeInHierarchy == true && CoalLevel == 5)
            {
                coalPlants[i].SetActive(false);
                coalPlants2[i].SetActive(true);

            }
            if (coalPlants2[i].activeInHierarchy == true && CoalLevel == 10)
            {
                coalPlants2[i].SetActive(false);
                coalPlants3[i].SetActive(true);

            }
            if (coalPlants3[i].activeInHierarchy == true && CoalLevel == 15)
            {
                coalPlants3[i].SetActive(false);
                coalPlants4[i].SetActive(true);
            }
        }
        CoalLevel += 5;
    }
}
