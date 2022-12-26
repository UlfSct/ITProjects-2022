using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndButtomController : MonoBehaviour
{
    public Canvas dialog;
    public Text text;
    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseDialog() 
    {
        text.gameObject.SetActive(true);
        text.text = ">247 242 238    235 229 230 232 242    226    238 241 237 238 226 229    241 242 240 238 234 234 232?";
        inputField.gameObject.SetActive(true);
        inputField.text = ">";
        this.gameObject.SetActive(false);
        dialog.gameObject.SetActive(false);
    }
}
