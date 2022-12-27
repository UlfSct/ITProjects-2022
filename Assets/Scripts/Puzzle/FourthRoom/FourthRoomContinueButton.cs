using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourthRoomContinueButton : MonoBehaviour
{
    public Text textField;
    public Text overInputField;
    public InputField inputField;
    public CharDialog dialogues;
    public Button button1;
    public DoubleUIController script;

    public void ContinueDailogue()
    {
        if (script.end)
        {
            textField.text = dialogues.sentences[2];
            button1.gameObject.SetActive(true);    
            button1.GetComponentInChildren<Text>().text = "Завершить";
        }
        else
        {
            textField.text = dialogues.sentences[1];
            button1.gameObject.SetActive(false);
            inputField.gameObject.SetActive(true);
            overInputField.gameObject.SetActive(true);
        }
    }
}