using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globe : MonoBehaviour
{
    // This script takes care of the on click feature of the globe
    public GameObject GlobeObject;
    static bool OnMouse = false;
    [SerializeField]
    private float spinSpeed;

    void Update()
    {
        transform.Rotate(0,0, spinSpeed, Space.Self);
    }

    private void OnMouseOver()
    {   
        if (Input.GetMouseButtonDown(0))
        {

            if (UI.BuildingMenuActive == false)
            {
                StatsManager.Currency++;
                Scale();
                StartCoroutine(Scale());
                
            }
        }
        if (TutorialScript.tutorialIndex == 1 && Input.GetMouseButtonDown(0))
        {
            print("wtf");
            TutorialScript.tutorialIndex++;
        }


    }
    IEnumerator Scale()
    {
        //This is a coroutine
        GlobeObject.transform.localScale = new Vector3(110000f, 110000f, 110000f);

        yield return new WaitForSeconds(0.1f);

        GlobeObject.transform.localScale = new Vector3(100000f, 100000f, 100000f);
    }
}
