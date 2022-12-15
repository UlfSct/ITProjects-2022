using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricCharachterMoving : MonoBehaviour
{
    public float movementSpeed = 1f;
    public PauseMenu pauseMenu;
    private Rigidbody2D rbody;
    
    private void Awake() 
    {
        rbody = GetComponentInChildren<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 currentPos = rbody.position;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
        /*
        if (pauseMenu.pauseGame)
        {
            inputVector = new Vector2(0, 0);
        }   
        else
        {
            inputVector = new Vector2(horizontalInput, verticalInput);
        }
*/
        inputVector = Vector2.ClampMagnitude(inputVector, 1);

        Vector2 movement = inputVector * movementSpeed;

        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;

        rbody.MovePosition(newPos);

    }
}
