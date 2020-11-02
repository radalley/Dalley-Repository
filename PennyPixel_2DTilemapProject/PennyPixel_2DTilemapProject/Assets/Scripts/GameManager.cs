using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public static GameManager instance;
    public int score;
    public GameObject pauseMenu;
    private string CurrentLevelName = string.Empty;


   /* private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }*/
    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if(ao == null)
        {
            return;
        }
        CurrentLevelName = levelName;
    }
  
    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }
    public void TimeSet()
    {
        Time.timeScale = 1f;
    }
    public void Unpause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }
    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            return;
        }
        //CurrentLevelName = levelName;
    }
    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
        if (ao == null)
        {
            return;
        }
        //CurrentLevelName = levelName;
    }
}
