using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class TimeScript3 : MonoBehaviour
{

    DateTime currentDate;
    DateTime oldDate;
    TimeSpan difference;

    float CurrencyGain;
    float EnvironmentIncreased;
    double diff;

    public Text GainText;
    public GameObject GainButton;

    void Start()
    {
        //Store the current time when it starts
        currentDate = System.DateTime.Now;

        //Grab the old time from the player prefs as a long
        long temp = Convert.ToInt64(PlayerPrefs.GetString("sysString"));

        //Convert the old time from binary to a DataTime variable
        DateTime oldDate = DateTime.FromBinary(temp);

        //Use the Subtract method and store the result as a timespan variable
        difference = currentDate.Subtract(oldDate);

    }
    private void Update()
    {
        if (TutorialScript.TutorialOn == 0)
        {
            GainButton.SetActive(false);
        }
        diff = difference.TotalSeconds;
        float ConvertedDifference = (float)diff;
        CurrencyGain = CurrencyManager.CurrencyIncrease * ConvertedDifference;
        EnvironmentIncreased = EnvironmentManager.EnvironmentIncrease * ConvertedDifference;
        GainText.text = "You earned " + Mathf.RoundToInt(CurrencyGain) + " currency and the environment damage increased by " + Mathf.RoundToInt(EnvironmentIncreased) + " in the timeframe you did not play!";
    }

    void OnApplicationPause(bool pauseStatus)
    {
        //Savee the current system time as a string in the player prefs class
        PlayerPrefs.SetString("sysString", System.DateTime.Now.ToBinary().ToString());

        print("Saving this date to prefs: " + System.DateTime.Now);
    }

    public void Claim()
    {
        StatsManager.Environment += EnvironmentIncreased;
        StatsManager.Currency += CurrencyGain;
        GainButton.SetActive(false);
    }

}