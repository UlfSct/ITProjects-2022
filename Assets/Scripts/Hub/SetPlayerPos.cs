using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerPos : MonoBehaviour
{
    public string posNumber;
    public SpriteRenderer playerRS;
    public SpriteRenderer transRS;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            playerRS.sortingLayerName = "PlayerPos" + posNumber;
            transRS.sortingLayerName = "PlayerPos" + posNumber;
        }
    }
}
