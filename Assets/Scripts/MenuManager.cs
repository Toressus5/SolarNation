using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // This script takes care of the menu navigation
    public static bool isLoading = false;
    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadOldGame()
    {
        SceneManager.LoadScene(1);
        isLoading = true;
    }
}
