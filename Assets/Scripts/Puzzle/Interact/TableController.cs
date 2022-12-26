using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableController : MonoBehaviour
{
    public GameObject CanvasPuzzle;
    public bool isOpen;
    public GameObject tableTrigger;

    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen && Input.GetKeyDown(KeyCode.Escape))
        {
            closePuzzle();
        }
    }

    public void openPuzlle()
    {
        CanvasPuzzle.SetActive(true);
        tableTrigger.SetActive(false);
        isOpen = true;
    }

    public void closePuzzle()
    {
        CanvasPuzzle.SetActive(false);
        tableTrigger.SetActive(true);
        isOpen = false;
    }
    
}
