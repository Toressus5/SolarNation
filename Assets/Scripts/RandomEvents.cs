using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEvents : MonoBehaviour
{
    // this script takes care and holds all the random events
    bool RandomEventTrigger = true;

    private void Start()
    {
        InvokeRepeating("RandomEvent", 60f, 60f);
    }
    void RandomEvent()
    {
        if (Random.value < 0.5 && RandomEventTrigger)
        {
            if (Random.value < 0.03 && RandomEventTrigger)
            {
                Announcer.AnnounceText = "The oil rig explodes. The ocean is filled with oil. 10% of the environment gets damaged.";
                StatsManager.Environment += 10;
                RandomEventTrigger = false;
            }
            if (Random.value < 0.03 && RandomEventTrigger)
            {
                Announcer.AnnounceText = "Nuclear powerplant dumps nuclear rests in the river";
                StatsManager.Environment += 10;
                RandomEventTrigger = false;
            }
            if (Random.value < 0.03 && RandomEventTrigger)
            {
                Announcer.AnnounceText = "Nuclear powerplant explodes";
                StatsManager.Environment += 50;
                StatsManager.Currency -= 20;
                RandomEventTrigger = false;
            }
            RandomEventTrigger = true;
        }
    }
}
