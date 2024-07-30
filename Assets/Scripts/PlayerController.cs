using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declaring and initializing Variables
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;

    // Update is called once per frame
    void Update()
    {
        // Getting the Player Input from the horizontal Axis.
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Move the vehicle forward
        transform.Translate(Vector3.forward * (Time.deltaTime * speed)); 
        transform.Translate(Vector3.right * (Time.deltaTime * turnSpeed * horizontalInput));
    }
}
