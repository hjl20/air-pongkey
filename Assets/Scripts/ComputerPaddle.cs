
using UnityEngine;

public class ComputerPaddle : Paddle
{
    //Modifiable from Unity UI
    public Rigidbody2D ball;

    private void FixedUpdate() 
    {
        //Ball incoming
        if (this.ball.velocity.x > 0.0f) {
            //Move up if above, else move down
            if (this.ball.position.y > this.transform.position.y) {
                rb.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y) {
                rb.AddForce(Vector2.down * this.speed);
            }
        } 
        //Center position (ball not incoming)
        else {
            if (this.transform.position.y > 0.0f) {
                rb.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f) {
                rb.AddForce(Vector2.up * this.speed);
            }
        }
    }

}
