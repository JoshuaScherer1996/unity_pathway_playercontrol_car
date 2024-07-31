using UnityEngine;

public class AutomaticDrive : MonoBehaviour
{
    // Declaring the constant.
    private const float Speed = 20.0f;
    
    private void Update()
    {
        // Making the vehicle constantly drive forward based on the Speed constant and seconds.
        transform.Translate(Vector3.forward * (Time.deltaTime * Speed));
    }
}
