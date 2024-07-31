using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declaring and initializing Variables
    private const float Speed = 20.0f;
    private const float TurnSpeed = 50.0f;
    private float _horizontalInput;
    private float _forwardInput;

    // Update is called once per frame
    private void Update()
    {
        // Getting the Player Input from the horizontal and vertical Axis.
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical"); 
        
        // Moves the vehicle forward in relation to the input.
        transform.Translate(Vector3.forward * (Time.deltaTime * Speed * _forwardInput)); 
        // Turns the vehicle in relation to the input.
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * _horizontalInput);
    }
}
