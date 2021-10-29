using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }

    public static bool PauseState = false;
    public GameObject PauseMenuUI;
    public GameObject GameUI;

    public void Resume()
    {
        Cursor.visible = false;
        AudioListener.pause = false;
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseState = false;
    }
    public void Pause()
    {
        Cursor.visible = true;
        AudioListener.pause = true; 
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseState = true;
    }
    public void PauseQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void PauseStartMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        DifficultySelect.difficultyvalue = 1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseState)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}