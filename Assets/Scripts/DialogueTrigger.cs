using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{

    List<GameObject> citizenList = new List<GameObject>();
    GameObject player;
    Dialogue dialog;
    public GameObject dialogManager;
    private bool DialogueCollider = false;
 
    private void Start()
    {
        
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && DialogueCollider)
        {
            dialogManager.GetComponent<Dialogue>().StartConversation();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Entered");
            DialogueCollider = true;
        }
    }

}
