using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;
    
    // Update is called once per frame
    void Update()
    {
        float horiontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horiontalInput * rotationSpeed * Time.deltaTime);
    }
}
