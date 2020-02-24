using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller; //this references the CharacterController that the Player has, so that it can properly move

    public float speed = 12f; //this determines the speed of the character

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");  //these floats set up the axis references for the movement
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; //this makes it so that the player itself moves while pressing forwards or side to side

        controller.Move(move * speed * Time.deltaTime); //this basically makes it so that the player moves at the same pace, regardless of the frame rate or time passed

        Screen.lockCursor = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }

}
