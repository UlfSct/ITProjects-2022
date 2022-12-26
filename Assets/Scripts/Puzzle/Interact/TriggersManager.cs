using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggersManager : MonoBehaviour
{
    public GameObject firstRoomTrigger;
    public GameObject secondRoomTrigger;
    public GameObject thirdRoomTrigger;
    public GameObject fourthRoomTrigger;

    private int firstRoom;
    private int secondRoom;
    private int thirdRoom;
    private int fourthRoom;

    public UICharManager charScript;
    public InstantiateDialogue boolScript;
    public IntUIController intScript;
    public DoubleUIController doubleScript;

    // Start is called before the first frame update
    void Start()
    {
        firstRoom = PlayerPrefs.GetInt("FirstRoom");
        secondRoom = PlayerPrefs.GetInt("SecondRoom");
        thirdRoom = PlayerPrefs.GetInt("ThirdRoom");
        fourthRoom = PlayerPrefs.GetInt("FourthRoom");

        firstRoomTrigger.SetActive(firstRoom == 1 ? true : false);
        secondRoomTrigger.SetActive(firstRoom == 1 ? true : false);
        thirdRoomTrigger.SetActive(firstRoom == 1 ? true : false);
        fourthRoomTrigger.SetActive(firstRoom == 1 ? true : false);
    }

    // Update is called once per frame
    void Update()
    {
        if (charScript.end)
        {
            PlayerPrefs.SetInt("FirstRoom", 1);
            firstRoomTrigger.SetActive(true);
        }
            

        if (boolScript.end)
        {
            PlayerPrefs.SetInt("SecondRoom", 1);
            secondRoomTrigger.SetActive(true);
        }

        if (intScript.end)
        {
            PlayerPrefs.SetInt("ThirdRoom", 1);
            thirdRoomTrigger.SetActive(true);
        }

        if (doubleScript.end)
        {
            PlayerPrefs.SetInt("FourthRoom", 1);
            fourthRoomTrigger.SetActive(true);
        }
    }
}
