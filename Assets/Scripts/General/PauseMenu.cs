using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool pauseGame;
    public GameObject pauseMenu;
    public GameObject pauseText;

    public InputField consoleParent;
    public Text console;

    public GameObject incorrectInput;

    public ElevatorMenu elevatorMenu;

    private string inputString; 


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
            // вывести окно настроек
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
        Time.timeScale = 0f;
        pauseGame = true;
    }

    
}
