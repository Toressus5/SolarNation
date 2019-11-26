using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Slider slider;
    public Text progressText;
    bool firstPlay;
    public GameObject loading;
    public GameObject button;
    void Awake()
    {
        if (Application.isEditor == false)
        {
            if (PlayerPrefs.GetInt("FirstPlay", 1) == 1)
            {
                firstPlay = true;
                PlayerPrefs.SetInt("FirstPlay", 0);
                PlayerPrefs.Save();
            }
            else
                firstPlay = false;
        }
        else
        {
            PlayerPrefs.DeleteAll();
        }
    }
        public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        MenuManager.isLoading = true;
        button.SetActive(false);
        loading.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            slider.value = progress;
            progressText.text = "Loading " + progress * 100f + "%";

            yield return null;
        }

    }
}
