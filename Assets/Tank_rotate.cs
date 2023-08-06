using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_rotate : MonoBehaviour
{

    public float speed = 10.0f;
    public float rotationSpeed = 0.5f;

    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0));
        }

        // Check if the right arrow key is pressed.
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0));
        }
      
    }
}
