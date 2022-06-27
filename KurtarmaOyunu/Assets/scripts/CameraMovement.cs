using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Player; 
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(Player.position.x, -128f, 86f), transform.position.y, transform.position.z);
        
        if (transform.position.x<=0)
        {
            
           transform.position = new Vector3(0, 0,-10);
        }
        if (transform.position.x >= 32.1f)
        {
            
            transform.position = new Vector3(32.1f, 0,-10);
        }
    }
}
