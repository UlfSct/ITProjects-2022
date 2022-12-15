using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarracksMiddleSetBack : MonoBehaviour
{
    SpriteRenderer sr;

    void Start()
    {
        sr = GameObject.Find("BarracksMiddle").GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            sr.sortingLayerName = "BarracksMiddle_Back";
        }
        
    }
}
