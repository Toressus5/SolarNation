using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript2 : MonoBehaviour
{

    float CurrencyGain;
    double TimeGap;
    public GameObject GainButton;
    System.DateTime SavedTime = new System.DateTime(2019, 6, 16, 23, 49, 0);
    System.DateTime CurrentTime;
    public Text GainText;

    void Start()
    {
        GainButton.SetActive(true);
        Time.timeScale = 0f;
        InvokeRepeating("SaveTime", 10f, 10f);
        if (CurrentTime.Day != SavedTime.Day)
        {
            StatsManager.Currency += 100;
        }
    }
    void Update()
    {
        CurrentTime = System.DateTime.Now;
        System.TimeSpan diff = CurrentTime - SavedTime;
        TimeGap = diff.TotalSeconds;
        float ConvertedTimeGap = (float)TimeGap;
        CurrencyGain = CurrencyManager.CurrencyIncrease * ConvertedTimeGap;
        GainText.text = "Currency gained since the last time you played " + CurrencyGain;
    }
    public void SaveTime()
    {
        SavedTime = System.DateTime.Now;
    }

    public void Gain()
    {
        StatsManager.Currency += CurrencyGain;
        Time.timeScale = 1f;
        GainButton.SetActive(false);
        SavedTime = CurrentTime;
    }
}
