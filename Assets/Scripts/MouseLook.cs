using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f; //this sets the sensitivity of the mouse as you move it

    public Transform playerBody; //this references the actual player prefab the camera is attached to

    float xRotation = 0f; //this sets the rotation to the front
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //this locks the cursor to the center so you don't have to deal with seeing it while you play
    }

    // the floats set up the XY movement for the camera, while the rotations move the camera at the same speed regardless of framerate or time passed. The transform and playerBody rotate the player model while you look.
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //the clamp helps prevent the camera from turning all the way around in one direction to make the movement more realistic

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
