using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingDialogTrigger : MonoBehaviour
{
    public GameObject dialogueMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!PlayerPrefs.HasKey("startingDialogueEnded"))
        {
            if (collision.gameObject.name.Equals("Player"))
            {
                dialogueMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
}
