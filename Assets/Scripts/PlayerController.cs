using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // The speed at which the player moves

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical input axes (left/right and up/down arrow keys)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Move the player based on the input axes
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        transform.position += movement * speed * Time.deltaTime;
    }
}
