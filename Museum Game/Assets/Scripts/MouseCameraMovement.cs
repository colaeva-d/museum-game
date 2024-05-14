using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float mouseSensitivity = 300f;

    float xRotation = 0f;
    float yRotation = 0f;

    void Start()
    {
        // Lock the cursor to the center of the screen and make it invisible
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Control rotation around x axis (up and down)
        xRotation -= mouseY;

        // Clamp the rotation because we can't stand on our head
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Control rotation around the y axis (left and right)
        yRotation += mouseX;

        // Apply both rotations
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

    }



}
