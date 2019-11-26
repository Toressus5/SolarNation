using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    float CurrencyGain;
    double TimeGap;
    public GameObject GainButton;
    private System.DateTime SavedTime = System.DateTime.Now;
    static public string time;
    System.DateTime CurrentTime;
    public Text GainText;
    bool pickupProfit;

    void Start()
    {
        //Change back to int from string; with fucntion below
        
        GainButton.SetActive(true);
        DayNight.day = true;
        Time.timeScale = 1f;
        InvokeRepeating("SaveTime", 10f, 10f);
        if (CurrentTime.Day != SavedTime.Day)
        {
            StatsManager.Currency += 100;
        }
        pickupProfit = false;
    }
    void Update()
    {

        CurrentTime = System.DateTime.Now;
        // Difference between saved and current time
        System.TimeSpan diff = CurrentTime - SavedTime;
        // to seconds
        TimeGap = diff.TotalSeconds;
        // to float
        float ConvertedTimeGap = (float)TimeGap;
        // How much is gained
        CurrencyGain = CurrencyManager.CurrencyIncrease * ConvertedTimeGap;
        // put it in text
        GainText.text = "Currency gained since the last time you played " + CurrencyGain;
        //changing it to the string
        time = SavedTime.ToString("HH:mm:ss");
        SavedTime = System.DateTime.Parse(time);
        
        print(CurrencyGain);
        print(SavedTime + "saved");
        print(CurrentTime + "current");
    }
    public void SaveTime()
    {
        if (pickupProfit == true)
        {
            
            SavedTime = System.DateTime.Now;
        }



    }
    public void Gain()
    {
        StatsManager.Currency += CurrencyGain;
        Time.timeScale = 1f;
        GainButton.SetActive(false);
        SavedTime = System.DateTime.Now;
        pickupProfit = true;
    }
}
