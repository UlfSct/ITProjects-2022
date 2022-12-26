using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitFourthRoom : MonoBehaviour
{
    public SpriteRenderer sr;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Character"))
        {
            sr.sortingLayerName = "PlayerInFrontOfTable";
        }
    }
}
