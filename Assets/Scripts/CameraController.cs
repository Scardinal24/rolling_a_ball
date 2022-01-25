using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    // associates to the game object (ball)
    public GameObject player;

    private Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        // makes it smightly offset from the ball so it doesn't enitrely move exactly with the ball
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
