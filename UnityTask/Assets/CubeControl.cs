using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour


{
    // Rotation speed of the cube.
    public float rotationSpeed = 30.0f;

    // Scaling speed when the space key is held.
    public float scaleSpeed = 1.0f;

    // A flag to track if the cube is currently scaling.
    private bool isScaling = false;

    // Update is called once per frame.
    void Update()
    {
        // Get input from the arrow keys to control the cube's rotation.
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Rotate the cube around its Y-axis based on the input.
        transform.Rotate(Vector3.up, rotation * Time.deltaTime);

        // Check if the space key is held down.
        if (Input.GetKey(KeyCode.Space))
        {
            // If the space key is held, gradually increase the cube's size.
            isScaling = true;
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        }
        else if (isScaling)
        {
            // If the space key was released, stop scaling.
            isScaling = false;
        }
    }
}