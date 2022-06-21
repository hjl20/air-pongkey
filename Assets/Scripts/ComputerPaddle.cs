
using UnityEngine;

public class ComputerPaddle : Paddle
{
    //Get reference to ball
    public Rigidbody2D ball;

    private void FixedUpdate() 
    {
        //Ball is incoming
        if (this.ball.velocity.x > 0.0f) {
            if (this.ball.position.y > this.transform.position.y) {
                rb.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y) {
                rb.AddForce(Vector2.down * this.speed);
            }
        } 
        //Reset position to center
        else {
            if (this.transform.position.y > 0.0f) {
                rb.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f) {
                rb.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
