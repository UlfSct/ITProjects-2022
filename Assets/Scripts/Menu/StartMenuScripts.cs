using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScripts : MonoBehaviour
{
    private int savedCurrentLevel;
    private bool thereIsStartedGame;
    public GameObject continueButton;
    public GameObject mainMenu;
    public GameObject settingsMenu;


    public void Start()
    {
        if(!PlayerPrefs.HasKey("currentLevel"))
        {
            PlayerPrefs.SetInt("currentLevel", 0);
            PlayerPrefs.SetInt("firstLevelCompleted", 0);
            PlayerPrefs.SetInt("secondLevelCompleted", 0);
            PlayerPrefs.SetInt("thereIsStartedGame", 0);
            PlayerPrefs.Save();
        }

        thereIsStartedGame = PlayerPrefs.GetInt("thereIsStartedGame") == 1 ? true : false;
        savedCurrentLevel = PlayerPrefs.GetInt("currentLevel");

        if (thereIsStartedGame)
        {
            continueButton.SetActive(true);
        }
        else
        {
            continueButton.SetActive(false);
        }
    }

    public void ContinueGame()
    {
        switch (savedCurrentLevel)
        {
            case 0:
                SceneManager.LoadScene("Hub");
                break;

            case 1:
                SceneManager.LoadScene("Puzzle");
                break;

            case 2:
                SceneManager.LoadScene("Arena");
                break;
        }
    }

    public void StartNewGame()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("currentLevel", 0);
        PlayerPrefs.SetInt("firstLevelCompleted", 0);
        PlayerPrefs.SetInt("secondLevelCompleted", 0);
        PlayerPrefs.SetInt("thereIsStartedGame", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Hub");
    }

    public void GoToMain()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void GoToSettings()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
