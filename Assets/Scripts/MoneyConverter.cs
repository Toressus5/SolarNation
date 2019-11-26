using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyConverter : MonoBehaviour
{
    private static MoneyConverter instance;
    public static MoneyConverter Instance
    {
        get
        {
            return instance;
        }
    }
    void Start()
    {
        CreateInstance();
    }

    void CreateInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public string CurrencyToString(float valueToConvert)
    {
        if (valueToConvert >= 1000000f) // millions
        {

            valueToConvert = (valueToConvert / 1000000f);
            if (valueToConvert >= 100f)
            {
                return valueToConvert.ToString("0") + "M";
            }
            else if (valueToConvert >= 10f)
            {
                return valueToConvert.ToString("0.0") + "M";
            }
            else
            {
                return valueToConvert.ToString("0.00") + "M";
            }
        }
            if (valueToConvert >= 1000000000f) // Billions
        {

            valueToConvert = (valueToConvert / 1000000000f);
            if (valueToConvert >= 100f)
            {
                return valueToConvert.ToString("0") + "B";
            }
            else if (valueToConvert >= 10f)
            {
                return valueToConvert.ToString("0.0") + "B";
            }
            else
            {
                return valueToConvert.ToString("0.00") + "B";
            }
        }
        if (valueToConvert >= 1000000000000f) // Trilions
        {

            valueToConvert = (valueToConvert / 1000000000000f);
            if (valueToConvert >= 100f)
            {
                return valueToConvert.ToString("0") + "T";
            }
            else if (valueToConvert >= 10f)
            {
                return valueToConvert.ToString("0.0") + "T";
            }
            else
            {
                return valueToConvert.ToString("0.00") + "T";
            }
        }
        if (valueToConvert >= 1000000000000000f) // Quadrilion
        {

            valueToConvert = (valueToConvert / 1000000000000000f);
            if (valueToConvert >= 100f)
            {
                return valueToConvert.ToString("0") + "Quad";
            }
            else if (valueToConvert >= 10f)
            {
                return valueToConvert.ToString("0.0") + "Quad";
            }
            else
            {
                return valueToConvert.ToString("0.00") + "Quad";
            }
        }
        if (valueToConvert >= 1000000000000000000f) // Quintillion
        {

            valueToConvert = (valueToConvert / 1000000000000000000f);
            if (valueToConvert >= 100f)
            {
                return valueToConvert.ToString("0") + "Quint";
            }
            else if (valueToConvert >= 10f)
            {
                return valueToConvert.ToString("0.0") + "Quint";
            }
            else
            {
                return valueToConvert.ToString("0.00") + "Quint";
            }
        }
        
        else if (valueToConvert >= 1000) // thousands
        {
            valueToConvert = (valueToConvert / 1000f);
            if (valueToConvert >= 100f) return valueToConvert.ToString("0") + "k";
            else if (valueToConvert >= 10f) return valueToConvert.ToString("0.0") + "k";
            else return valueToConvert.ToString("0.00") + "k";
        }
        return valueToConvert.ToString();
    }
}
