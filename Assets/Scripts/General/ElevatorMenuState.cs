using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMenuState : MonoBehaviour
{
    public ElevatorMenu elevatorMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            elevatorMenu.menuOpened = true;
            elevatorMenu.Show();
        }
        
    }
}
