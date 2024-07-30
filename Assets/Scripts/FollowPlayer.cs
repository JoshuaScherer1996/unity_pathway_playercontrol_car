using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Declaring and initializing variables.
    public GameObject player;
    private readonly Vector3 _offset = new Vector3(0, 5, -7);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Offsetting the camera away from the players position by adding a new vector3 instance.
        transform.position = player.transform.position + _offset;
    }
}
