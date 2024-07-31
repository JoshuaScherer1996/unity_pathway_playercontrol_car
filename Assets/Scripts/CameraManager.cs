using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Declaring and initializing variables.
    public GameObject mainCam;
    public GameObject firstPersonCam;
    public GameObject player;
    private bool _isMainCamActive;
    private readonly Vector3 _offsetFirstPerson = new (0, 2, 1);
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
        // Offsetting the camera away from the players position by adding  new vector3 instances.
        mainCam.transform.position = player.transform.position + _offsetMain;
        firstPersonCam.transform.position = player.transform.position + _offsetFirstPerson;
        firstPersonCam.transform.rotation = player.transform.rotation;
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
