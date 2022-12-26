using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool pauseGame;
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    public GameObject pauseText;

    public InputField consoleParent;
    public Text console;

    public GameObject incorrectInput;

    public ElevatorMenu elevatorMenu;

    private string inputString; 

    public void Start()
    {
        if (PlayerPrefs.HasKey("PauseMenuHintShow"))
        {
            pauseText.SetActive(false);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !elevatorMenu.menuOpened) 
        {
            ChangeState();
        }

        inputString = console.text;
    }

    public void OnValueChanged()
    {
        inputString = console.text;
    }

    public void OnSubmit()
    {
        consoleParent.text = "";

        if (inputString == "0")
        {
            LoadMenu();
            incorrectInput.SetActive(false);
        }
        else if (inputString == "1")
        {
            GoToSettings();
            incorrectInput.SetActive(false);
        }
        else if (inputString == "2")
        {
            Resume();
            incorrectInput.SetActive(false);
        }
        else
        {
            ThrowError();
        }
    }

    public void ThrowError()
    {
        incorrectInput.SetActive(true);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void ChangeState()
    {
        if (pauseGame)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pauseGame = false;

        consoleParent.text = "";
        incorrectInput.SetActive(false);
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        pauseText.SetActive(false);
        PlayerPrefs.SetInt("PauseMenuHintShow", 0);
        Time.timeScale = 0f;
        pauseGame = true;
    }

    public void GoToMain()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void GoToSettings()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
}
