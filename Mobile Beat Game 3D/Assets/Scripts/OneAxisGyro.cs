using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneAxisGyro : MonoBehaviour
{
    private void Start()
    {
        Input.gyro.enabled = true;
    }

    private void Update()
    {
        Vector3 previousEulerAngles = transform.eulerAngles;
        Vector3 gyroInput = Input.gyro.rotationRateUnbiased;

        Vector3 targetEulerAngles = previousEulerAngles + gyroInput * Time.deltaTime * Mathf.Rad2Deg;
        targetEulerAngles.x = 15f; // Only this line has been added
        targetEulerAngles.y = 0.0f;

        transform.eulerAngles = targetEulerAngles;
    }
}
