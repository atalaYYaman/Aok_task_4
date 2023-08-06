using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class tank_fire : MonoBehaviour
{

    public float speed = 10.0f;

    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        Vector3 hizEklentisi = playerInput * Time.deltaTime * speed;
        transform.position += hizEklentisi;
        
        
    }
}

