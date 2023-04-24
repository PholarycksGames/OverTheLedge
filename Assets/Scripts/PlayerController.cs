using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f; 
    [SerializeField] private float rotation = 720f; 

    // Update is called once per frame
    void Update()
    {
        MyInput();
    }

    private void MyInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Move the player based on the input axes
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        movement.Normalize();
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // if user is on the move
        if(movement != Vector3.zero)
        {
            Quaternion rotationDirection = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotationDirection, rotation * Time.deltaTime);
        }
    }
}
