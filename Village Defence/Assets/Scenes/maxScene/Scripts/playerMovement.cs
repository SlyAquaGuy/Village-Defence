using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float horizontalInput;
    public float verticalInput;
    public float horPos;
    public float verPos;

    void Update()
    {
        //Gets the key presses
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Moves the player based on the key presses
        transform.Translate(Vector3.back * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * verticalInput);

        //shows the horizontal and vertical position of the player
        horPos = transform.position.z * -1;
        verPos = transform.position.x;
    }
}
