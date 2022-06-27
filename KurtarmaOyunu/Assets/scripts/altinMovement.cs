using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altinMovement : MonoBehaviour
{
    public float altinSpeed;
    
    
    void Update()
    {
        transform.Rotate(0, altinSpeed * Time.deltaTime, 0);
    }

    
}

