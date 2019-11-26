using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    // This script takes care of the day and night feature
    public float timeToChange;
    public float startTimeToChange;
    public static bool day;

    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.backgroundColor = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        print(day);
        if (timeToChange <= 0)
        {
            if (cam.backgroundColor == Color.black)
            {
                timeToChange = startTimeToChange;
                cam.backgroundColor = Color.blue;
                day = true;
            }
            else if (cam.backgroundColor == Color.blue)
            {
                timeToChange = startTimeToChange;
                cam.backgroundColor = Color.black;
                day = false;
            }
        }
        else
        {
            timeToChange -= UnityEngine.Time.deltaTime;
        }
    }
}
