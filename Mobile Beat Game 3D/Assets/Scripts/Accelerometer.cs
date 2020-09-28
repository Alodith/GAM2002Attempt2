using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    public float minRotation;
    public float maxRotation;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        Vector3 dir = Vector3.zero;

        
        dir.z = Mathf.Clamp(dir.z, minRotation, maxRotation);
        dir.z -= Input.acceleration.x;


        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        transform.Rotate(dir);
    }
}
