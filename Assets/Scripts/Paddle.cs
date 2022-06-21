
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //Get reference to physics object
    protected Rigidbody2D rb;

    private Vector2 startPosition;

    //Modifiable from Unity UI
    public float speed = 30.0f;

    //Initialization
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
