using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject firstPersonCam;
    public GameObject player;
    private bool _isMainCamActive;
    private readonly Vector3 _offset = new (0, 2, 1);
    
    private void Start()
    {
        // Ensure the main camera is active at the start
        mainCam.SetActive(true);
        firstPersonCam.SetActive(false);
        _isMainCamActive = true;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Camera Switch"))
        {
            SwitchCam();
        }
    }

    
    private void LateUpdate()
    {
        firstPersonCam.transform.position = player.transform.position + _offset;
        firstPersonCam.transform.rotation = player.transform.rotation;
    }
    
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
