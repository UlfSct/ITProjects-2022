using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InFrontOfTable : MonoBehaviour
{
    public SpriteRenderer sr;

    void Start()
    {
        //sr = GameObject.Find("FirstRoomTable").GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Character"))
        {
            sr.sortingLayerName = "PlayerInFrontOfTable";
        }
        
    }
}
