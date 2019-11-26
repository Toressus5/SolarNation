using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public GameObject continueButton;
    public GameObject player;

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {

        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
            
        }
        if (index + 1 == sentences.Length)
        {
            
        }
        else
        {
            Debug.Log(index + "     " + sentences.Length);
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void StartConversation()
    {
        StartCoroutine(Type());
    }
    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }
}
