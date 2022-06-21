
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //Modifiable speed
    public float speed = 30.0f;

    private Vector2 startPosition;

    //Get reference to physics object
    protected Rigidbody2D rb;

    //Initialization function
    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = rb.position;
    }


    public void ResetPosition()
    {
        rb.position = startPosition;
        rb.velocity = Vector2.zero;
    }
    
}
