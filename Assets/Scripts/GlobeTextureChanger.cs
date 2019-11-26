using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeTextureChanger : MonoBehaviour
{
    public Material environemnt1;
    public Material environemnt2;
    public Material environemnt3;
    public Material environemnt4;
    public Material environemnt5;
    GameObject[] plants;
    Renderer texture;
    public float environmentMeter;
    // Start is called before the first frame update
    void Start()
    {
        plants = GameObject.FindGameObjectsWithTag("Globe");
        foreach (GameObject environment in plants)
        {
            texture = environment.GetComponent<Renderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject environment in plants)
        {
            texture = environment.GetComponent<Renderer>();
            if (StatsManager.Environment <= 20)
            {
                texture.material = environemnt1;
            }
            if (StatsManager.Environment >= 20)
            {
                texture.material = environemnt2;
            }

            if (StatsManager.Environment >= 40)
            {
                texture.material = environemnt3;
            }
            if (StatsManager.Environment >= 60)
            {
                texture.material = environemnt4;
            }
            if (StatsManager.Environment >= 80)
            {
                texture.material = environemnt5;
            }
        }
    }
}
