using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManu : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField]
    private Slider Slider;
#pragma warning restore 0649

    public void PlayGame(int sceneIndex = 0)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = sceneIndex == 0 ? SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1) : 
                                                     SceneManager.LoadSceneAsync(sceneIndex);

        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            if(Slider != null)
                Slider.value = progress;

            yield return null;
        }

    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
