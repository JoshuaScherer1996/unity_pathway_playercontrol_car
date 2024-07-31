using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Declaring and initializing variables.
    public GameObject player;
    private readonly Vector3 _offsetMain = new (0, 5, -7);
    
    // LateUpdate is called after the Update method. Makes sure that the camera doesn't stutter.
    private void LateUpdate()
    {
        // Offsetting the main camera away from the players position by adding a new vector3 instance.
            transform.position = player.transform.position + _offsetMain;
    }
}
