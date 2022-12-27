using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICharManager : MonoBehaviour
{
    public Text outputText;
    public Text textOverInput;
    public CharDialog dialog;
    public string[] s;
    public Button endButton;
    public Button continueButton;
    public InputField inputField;
    public string inputText;
    public bool end = false;

    public void SaveInputText()
    {
        inputText = inputField.text;
    }

    // Update is called once per frame
    public void ContinueDialog()
    {
        if (inputText.ToLower() == "символ")
        {
            HappyEnd();
        }
        else 
        {
            BadEnd();
        }
    }

    private void HappyEnd()
    {
        outputText.text = dialog.sentences[1];
        inputField.gameObject.SetActive(false);
        textOverInput.gameObject.SetActive(false);
        endButton.gameObject.SetActive(true);
        end = true;
    }

    private void BadEnd()
    {
        outputText.text = dialog.sentences[2];
        inputField.gameObject.SetActive(false);
        textOverInput.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(true);
    }
}
