
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    //Modifiable from Unity UI
    public float startingSpeed = 25.0f;

    //Get reference of object (ball)
    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start() 
    {
        ResetPosition();
        AddStartingForce();
    }
    
    public void ResetPosition()
    {
        rb.position = Vector2.zero;
        rb.velocity = Vector2.zero;

    }

    public void AddStartingForce() 
    {
        //Left or right
        double x = Random.value < 0.5f ? -1.0f : 1.0;
        //Angled up or down
        double y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                         Random.Range(0.5f, 1.0f);
                                         
        Vector2 direction = new Vector2((float)x, (float)y);
        rb.AddForce(direction * this.startingSpeed);
    }

    //Add additional forces to ball (used for friction)
    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }

}
