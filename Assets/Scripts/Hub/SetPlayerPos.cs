using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerPos : MonoBehaviour
{
    public string posNumber;
    SpriteRenderer sr;

    void Start()
    {
        sr = GameObject.Find("Player").GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            sr.sortingLayerName = "PlayerPos" + posNumber;
        }
        
    }
}
