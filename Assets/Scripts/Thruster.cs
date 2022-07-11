using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    public float speed;
    public FixedJoystick fixedJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        // Brandon Code
        /*
        Vector3 direction = Vector3.up * fixedJoystick.Vertical;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);*/

        // Zac Code
        Vector3 direction = Vector3.up * fixedJoystick.Vertical;
        rb.MovePosition(direction * Time.deltaTime);

        /*Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0)
            playerVelocity.y = -2f;
        controller.Move(playerVelocity * Time.deltaTime);*/
    }
}
