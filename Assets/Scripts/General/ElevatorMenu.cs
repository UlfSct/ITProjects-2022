using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ElevatorMenu : MonoBehaviour
{
    public GameObject elevatorMenu;
    public PauseMenu pauseMenu;

    public InputField consoleParent;
    public Text console;

    public GameObject errorIncorrectInput;
    public GameObject errorAccessDenied;
    public GameObject errorAccessGranted;
    public GameObject errorAccessRetarded;

    public bool menuOpened = false;
    public int currentLevel;

    private string inputString; 

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && menuOpened) 
        {
            Hide();
        }
    }

    public void Hide()
    {
        elevatorMenu.SetActive(false);
        Time.timeScale = 1f;
        pauseMenu.pauseGame = false;

        consoleParent.text = "";
        HideErrors();
        menuOpened = false;
    }

    public void Show()
    {
        UpdateCurrentLevel();
        elevatorMenu.SetActive(true);
        Time.timeScale = 0f;
        pauseMenu.pauseGame = true;
    }

    public void UpdateCurrentLevel()
    {
        currentLevel = PlayerPrefs.GetInt("currentLevel");
    }

    public void OnValueChanged()
    {
        inputString = console.text;
    }

    public void OnSubmit()
    {
        HideErrors();

        consoleParent.text = "";
        string currentLevel = PlayerPrefs.GetInt("currentLevel").ToString();

        if (currentLevel == inputString)
        {
            errorAccessRetarded.SetActive(true);
        }
        else if (inputString == "0")
        {
            errorAccessGranted.SetActive(true);
            SceneManager.LoadScene("Hub");
            pauseMenu.pauseGame = false;
            menuOpened = false;
            PlayerPrefs.SetInt("currentLevel", 0);
            Time.timeScale = 1f;
        }
        else if (inputString == "1")
        {
            errorAccessGranted.SetActive(true);
            SceneManager.LoadScene("Puzzle");
            pauseMenu.pauseGame = false;
            menuOpened = false;
            PlayerPrefs.SetInt("currentLevel", 1);
            Time.timeScale = 1f;
        }
        else if (inputString == "2")
        {
            int firstLevelCompleted = PlayerPrefs.GetInt("firstLevelCompleted");

            if (firstLevelCompleted == 1)
            {
                errorAccessGranted.SetActive(true);
                SceneManager.LoadScene("Arena");
                pauseMenu.pauseGame = false;
                menuOpened = false;
                PlayerPrefs.SetInt("currentLevel", 2);
                Time.timeScale = 1f;
            }
            else
            {
                errorAccessDenied.SetActive(true);
            }
        }
        else
        {
            errorIncorrectInput.SetActive(true);
        }
    }

    public void HideErrors()
    {
        errorAccessGranted.SetActive(false);
        errorAccessRetarded.SetActive(false);
        errorAccessDenied.SetActive(false);
        errorIncorrectInput.SetActive(false);
    }
}

