using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    public float speed;
    public FixedJoystick fixedJoystick;
    public Rigidbody rb;

    void Update()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, fixedJoystick.Vertical, 0); // for js
    }

    public void moveUp()
    {
        rb.velocity = new Vector3(0, 1, 0); // works for button
    }
    public void moveDown()
    {
        rb.velocity = new Vector3(0, -1, 0); // works for button
    }
    public void noMove()
    {
        rb.velocity = Vector3.zero;
    }
}
