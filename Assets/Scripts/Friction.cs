
using UnityEngine;

public class Friction : MonoBehaviour
{
    //Modifiable from Unity UI
    public float frictionStrength = 0.5f;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Ball ball = other.gameObject.GetComponent<Ball>();

        //Reduce speed of ball by adding opposite force
        if (ball) {
            Vector2 normal = other.GetContact(0).normal;
            ball.AddForce(normal * this.frictionStrength);
        }
    }

}
