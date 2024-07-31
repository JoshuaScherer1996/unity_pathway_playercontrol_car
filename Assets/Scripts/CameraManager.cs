using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Declaring and initializing variables.
    public GameObject mainCam;
    public GameObject firstPersonCam;
    public GameObject player;
    private bool _isMainCamActive;
    private readonly Vector3 _offsetMain = new (0, 5, -7);
    
    
    private void Start()
    {
        // Setting the Status for the cameras at the start of the game.
        mainCam.SetActive(true);
        firstPersonCam.SetActive(false);
        _isMainCamActive = true;
    }
    
    private void Update()
    {
        // With the key input the SwitchCam Method is executed
        if (Input.GetButtonDown("Camera Switch"))
        {
            SwitchCam();
        }
    }
    
    // LateUpdate is called after the Update method. Makes sure that the camera doesn't stutter.
    private void LateUpdate()
    {
        // Offsetting the main camera away from the players position by adding a new vector3 instance.
        if (_isMainCamActive)
        {
            mainCam.transform.position = player.transform.position + _offsetMain;
        }
    }
    
    // Enables and disables the camera objects based on the current status of _isMainCamActive. Also changes said status.
    private void SwitchCam()
    {
        if (_isMainCamActive)
        {
            mainCam.SetActive(false);
            firstPersonCam.SetActive(true);
        }
        else
        {
            mainCam.SetActive(true);
            firstPersonCam.SetActive(false);
        }
        _isMainCamActive = !_isMainCamActive;
    }
}
