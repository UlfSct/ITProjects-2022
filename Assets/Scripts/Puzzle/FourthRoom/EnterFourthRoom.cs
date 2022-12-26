using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterFourthRoom : MonoBehaviour
{
    public SpriteRenderer sr;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Character"))
        {
            sr.sortingLayerName = "PlayerBehindTables";
        }
    }
}
