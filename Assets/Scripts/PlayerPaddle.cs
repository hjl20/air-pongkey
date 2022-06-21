
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 direction;

    //Called every frame of the game
    private void Update() 
    {
        //Get key presses
        direction = new Vector2(
            Input.GetAxis("Horizontal"), 
            Input.GetAxis("Vertical")
            );
            
        //Normalize directional speed
        direction = Vector2.ClampMagnitude(direction, 1f);
    }

    //Called fixed time intervals (associated with physics)
    private void FixedUpdate() 
    {
        //Add force when buttons are pressed
        if (direction.sqrMagnitude != 0) {
            rb.AddForce(direction * this.speed);
        }
    }

}
