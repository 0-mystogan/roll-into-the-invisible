using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseManuUI;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
                Resume();
            else
                Pause();
            
        }
    }

    private void Pause()
    {
        pauseManuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        pauseManuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void LoadManu()
    { 
        Time.timeScale = 1f;
        StartCoroutine(UnloadScene());
        SceneManager.LoadScene(0);
    }

    public void QutiGame()
    {
        Debug.Log("Quiting...");
        Application.Quit();
    }

    IEnumerator UnloadScene()
    {
        AsyncOperation operation = SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        yield return null;
    }
}
