using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject hand;
    public Transform handPos1;
    public Transform handPos2;
    public Transform handPos3;
    public Transform handPos4;
    public Transform handPos5;
    public Transform handPos6;
    public GameObject tutorial1;
    public GameObject tutorial2;
    public GameObject tutorial3;
    public GameObject tutorial4;
    public GameObject tutorial5;
    public GameObject tutorial6;

    public static float TutorialOn = 0;

    public static int tutorialIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TutorialOn == 0)
        {
            if (tutorialIndex == 0)
            {
                hand.transform.position = handPos1.position;
                hand.transform.rotation = handPos1.rotation;
                hand.SetActive(true);
                tutorial1.SetActive(true);
                StartCoroutine("WaitSomeSeconds", 5);

            }
            if (tutorialIndex == 1)
            {
                tutorial1.SetActive(false);
                hand.SetActive(false);
                tutorial2.SetActive(true);
                hand.transform.position = handPos2.position;
                hand.transform.rotation = handPos2.rotation;
                hand.SetActive(true);
            }
            if (tutorialIndex == 2)
            {
                if (tutorial3.activeInHierarchy == false)
                {
                    hand.SetActive(false);
                    tutorial2.SetActive(false);
                }


                if (StatsManager.Currency >= 100)
                {
                    //whhen you press building menu button
                    hand.transform.position = handPos3.position;
                    hand.transform.rotation = handPos3.rotation;
                    hand.SetActive(true);
                    tutorial3.SetActive(true);
                }
            }
            if (tutorialIndex == 4)
            {
                //when you press solar button
                hand.SetActive(false);
                tutorial3.SetActive(false);
                hand.transform.position = handPos4.position;
                hand.transform.rotation = handPos4.rotation;
                hand.SetActive(true);
                tutorial4.SetActive(true);
                StartCoroutine("WaitSomeSeconds", 6);

            }
            if (tutorialIndex == 5)
            {
                //when you press solar button
                hand.SetActive(false);
                tutorial4.SetActive(false);
                hand.transform.position = handPos5.position;
                hand.transform.rotation = handPos5.rotation;
                hand.SetActive(true);
                tutorial5.SetActive(true);
                StartCoroutine("WaitSomeSeconds2", 4);

            }
            if (tutorialIndex == 6)
            {
                //when you press solar button
                hand.SetActive(false);
                tutorial5.SetActive(false);
                hand.transform.position = handPos6.position;
                hand.transform.rotation = handPos6.rotation;
                hand.SetActive(true);
                tutorial6.SetActive(true);
                StartCoroutine("WaitSomeSeconds3", 4);


            }
            if (tutorialIndex == 7)
            {
                hand.SetActive(false);
                tutorial6.SetActive(false);
                TutorialOn = 1;
                print(TutorialOn);
            }
        }
        
    }

    IEnumerator WaitSomeSeconds(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        if (tutorialIndex == 0)
        {
            tutorialIndex = 1;
        }
        if (tutorialIndex == 4)
        {
            tutorialIndex = 5;
        }

    }
    IEnumerator WaitSomeSeconds2(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        if (tutorialIndex == 5)
        {
            tutorialIndex = 6;
        }
    }
    IEnumerator WaitSomeSeconds3(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        if (tutorialIndex == 6)
        {
            tutorialIndex = 7;
        }
    }

    private void TutorialOff()
    {
        
    }
}
