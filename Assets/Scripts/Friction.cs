using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friction : MonoBehaviour
{
    public float frictionStrength = 0.5f;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Ball ball = other.gameObject.GetComponent<Ball>();

        if (ball) {
            Vector2 normal = other.GetContact(0).normal;
            ball.AddForce(normal * this.frictionStrength);
        }
    }
}
