using UnityEngine;

public class AutomaticDrive : MonoBehaviour
{
    private const float Speed = 20.0f;
    
    private void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * Speed));
    }
}
