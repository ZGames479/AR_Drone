using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 6f;
    public FixedJoystick fixedJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        /*Vector3 direction = Vector3.forward * fixedJoystick.Vertical + Vector3.right * fixedJoystick.Horizontal;
        Vector3 newForce = direction * speed * Time.fixedDeltaTime;

        Vector3 zDirection = Vector3.zero;
        zDirection.x = fixedJoystick.Vertical;
        zDirection.z = fixedJoystick.Horizontal;
        
        if(rb.velocity.magnitude <= 5)
        {
            //rb.AddForce(newForce, ForceMode.VelocityChange);
            //rb.MovePosition(transform.TransformDirection(newForce));
            rb.MovePosition(transform.TransformDirection(zDirection * speed * Time.deltaTime));
        }
        else
        {
            rb.velocity = rb.velocity.normalized * 5;
        }

        Debug.Log(rb.velocity.magnitude);*/

        rb.velocity = new Vector3(fixedJoystick.Horizontal * speed, rb.velocity.y, fixedJoystick.Vertical * speed);

        if (fixedJoystick.Horizontal != 0 || fixedJoystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
            //transform.rotation *= Quaternion.Euler(0, -90, 0);
        }
    }
}
