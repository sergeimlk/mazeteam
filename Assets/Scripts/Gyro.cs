using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyro : MonoBehaviour
{
    // Rotation speed
    public float rotationSpeed = 10.0f;

    // Reference to the Rigidbody
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.x = Input.acceleration.x;
        dir.z = Input.acceleration.y;

        // Clamp the acceleration vector to the unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        // Apply rotation force to the Rigidbody
        rb.AddTorque(new Vector3(dir.z, 0, -dir.x) * rotationSpeed);

        Debug.Log("x : " + Input.acceleration.x);
        Debug.Log("y : " + Input.acceleration.y);
    }
}
