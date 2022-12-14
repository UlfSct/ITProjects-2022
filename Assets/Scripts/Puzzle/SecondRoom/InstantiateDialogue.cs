using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateDialogue : MonoBehaviour
{
    public GameObject Window;

    public Text text;
    public Button firstButton;
    public Button secondButton;

    public TextAsset ta;

    public string dialogueName;
    public bool end;

    [SerializeField]
    public int currentNode = 0;
    public int butClicked;
    Node[] nd;
    Dialogue dialogue;

    void Start()
    {
        text.enabled = true;
        firstButton.enabled = true;
        secondButton.enabled = true;
        Window.SetActive(true);
        dialogue = Dialogue.Load(ta);
        nd = dialogue.nodes;
        end = false;

        text.text = nd[currentNode].Npctext;

        firstButton.onClick.AddListener(but1);
        secondButton.onClick.AddListener(but2);

        AnswerClicked(18);  //18 - для присвоения начальных значений в диалоге что бы не создавать новую функцию
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

    public void AnswerClicked(int numberOfButton)
    {
        if (numberOfButton == 18)
            currentNode = 0;
        else
        {
           if (dialogue.nodes[currentNode].answers[numberOfButton].end == "true") end = true;

           if (dialogue.nodes[currentNode].answers[numberOfButton].closeDialog == "true")
           {
                Window.SetActive(false);
                PlayerPrefs.SetInt(dialogueName + "Ended", 1);
                Time.timeScale = 1f;

           }
                
           currentNode = dialogue.nodes[currentNode].answers[numberOfButton].nextNode;
        }

        text.text = dialogue.nodes[currentNode].Npctext;

        firstButton.GetComponentInChildren<Text>().text = dialogue.nodes[currentNode].answers[0].text;
        if (dialogue.nodes[currentNode].answers.Length == 2)
        {
            secondButton.enabled = true;
            secondButton.GetComponentInChildren<Text>().text = dialogue.nodes[currentNode].answers[1].text;
        }
        else {
            secondButton.enabled = false;
            secondButton.GetComponentInChildren<Text>().text = "";
        }
    }
}