using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Announcer : MonoBehaviour
{
    // this script takes care of the announcer/news
    public Text AnnouncerDisplay;
    static public string AnnounceText = "There is no news!";

    private void Update()
    {
        AnnouncerDisplay.text = AnnounceText;
    }
}
