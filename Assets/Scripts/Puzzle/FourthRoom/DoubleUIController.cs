using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleUIController : MonoBehaviour
{
    public GameObject dialogWindow;
    public Text textField;
    public Text overInputField;
    public CharDialog dialogue;
    public CharDialog answers;
    public Button button1;
    public Button button2;
    public InputField inputField;
    public int butClicked;
    public TableController interactableScript;

    public bool end;
    private int sentencesCount;
    private int answersCount;

    private void Start()
    {
        sentencesCount = 1;
        answersCount = 0;
        //button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        end = false;
        
        button1.onClick.AddListener(but1);
        button2.onClick.AddListener(but2);
    }

    private void but1()
    {
        butClicked = 0;
        AnswerClicked(0);
    }
    private void but2()
    {
        butClicked = 1;
        AnswerClicked(1);
    }

    public void Manage()
    {
        Debug.Log(sentencesCount);
        if (inputField.text == answers.sentences[answersCount].ToString())
        {
            if (sentencesCount == 1) sentencesCount += 2;
            else sentencesCount += 3;
            textField.text = dialogue.sentences[sentencesCount];
            inputField.text = "";
            answersCount++;
            if(sentencesCount == 9) 
            {
                inputField.gameObject.SetActive(false);
                overInputField.gameObject.SetActive(false);
                button1.gameObject.SetActive(true);
                button1.GetComponentInChildren<Text>().text = "Завершить";
                end = true;
            }
        } 
        else
        {
            textField.text = dialogue.sentences[sentencesCount + 1];
            inputField.gameObject.SetActive(false);
            overInputField.gameObject.SetActive(false);
            button1.gameObject.SetActive(true);
            button1.GetComponentInChildren<Text>().text = "Попробовать еще раз";
            button2.gameObject.SetActive(true);
            button2.GetComponentInChildren<Text>().text = "Завершить";
        }
    }

    public void AnswerClicked(int numberOfButton)
    {
        if (numberOfButton == 0) 
        {
            if (sentencesCount == 9)
            {
                dialogWindow.SetActive(false);
            }
            else
            {
                button1.gameObject.SetActive(false);
                button2.gameObject.SetActive(false);
                inputField.gameObject.SetActive(true);
                overInputField.gameObject.SetActive(true);
                inputField.text = "";
                if (sentencesCount == 0)
                {
                    textField.text = dialogue.sentences[0];
                }
                else
                {
                    //textField.text = dialogue.sentences[sentencesCount];
                    if (sentencesCount == 1) 
                    {
                        textField.text = dialogue.sentences[sentencesCount - 1];
                    }
                    else
                        textField.text = dialogue.sentences[sentencesCount];
                }
            }
        }
        else
        {
            // textField.text = dialogue.sentences[0];
            // answersCount = 0;
            // sentencesCount = 0;
            //interactableScript.isOpen = false;
            dialogWindow.SetActive(false);
        }
    }
}