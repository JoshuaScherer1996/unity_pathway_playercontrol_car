using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declaring and initializing Variables
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;

    // Update is called once per frame
    private void Update()
    {
        // Getting the Player Input from the horizontal and vertical Axis.
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Move the vehicle forward
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * forwardInput)); 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
