using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScripts : MonoBehaviour
{
    private int savedCurrentLevel;
    private bool thereIsStartedGame;
    public GameObject continueButton;


    public void Start()
    {
        if(!PlayerPrefs.HasKey("currentLevel"))
        {
            PlayerPrefs.SetInt("currentLevel", 0);
            PlayerPrefs.SetInt("firstLevelCompleted", 0);
            PlayerPrefs.SetInt("secondLevelCompleted", 0);
            PlayerPrefs.SetInt("thereIsStartedGame", 0);
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
        PlayerPrefs.SetInt("currentLevel", 0);
        PlayerPrefs.SetInt("firstLevelCompleted", 0);
        PlayerPrefs.SetInt("secondLevelCompleted", 0);
        PlayerPrefs.SetInt("thereIsStartedGame", 1);

        SceneManager.LoadScene("Hub");
    }

    public void ShowSettings()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
