using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarracksDownSetBack : MonoBehaviour
{
    SpriteRenderer sr;

    void Start()
    {
        sr = GameObject.Find("BarracksDown").GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            sr.sortingLayerName = "BarracksDown_Back";
        }
        
    }
}
