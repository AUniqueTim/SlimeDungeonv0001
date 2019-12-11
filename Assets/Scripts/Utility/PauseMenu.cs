﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Menu loading...");
    }
    public void LoadSettingsMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SettingsMenu");
        Debug.Log("Settings menu loading...");
    }
    public void LoadControlsMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("ControlsMenu");
        Debug.Log("Controls menu loading...");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Player quit game...");
    }
}