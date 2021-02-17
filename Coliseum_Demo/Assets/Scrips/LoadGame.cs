using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{ 
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public Text LoadingText;
    private int i = 1;

    public void levelLoad(int sceneIndex)
    {
        StartCoroutine(LoadAsynchonously(1));
    }

    IEnumerator LoadAsynchonously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Game");

        loadingScreen.SetActive(true);


        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = progress * 100f + "%";
            
            if (i == 1)
            {
                LoadingText.text = "Loading.";
                i = 2;
            }
            if (i == 2)
            {
                LoadingText.text = "Loading..";
                i = 3;
            }
            if (i == 3)
            {
                LoadingText.text = "Loading...";
                i = 1;
            }


            yield return null;
        }
    }
}
