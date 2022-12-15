using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompletion : MonoBehaviour
{
    public string levelNumber;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            PlayerPrefs.SetInt(levelNumber + "LevelCompleted", 1);
        }
        
    }
}
