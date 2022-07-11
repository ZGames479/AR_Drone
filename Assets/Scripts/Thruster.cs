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
    }

    public void moveUp()
    {
        //rb.transform.position += Vector3.up * 2f * Time.deltaTime;
        //rb.velocity = Vector3.up * speed * Time.deltaTime;
        rb.velocity = new Vector3(0, 1, 0);
    }
    public void moveDown()
    {
        //rb.transform.position += Vector3.up * -2f * Time.deltaTime;
        //rb.velocity = Vector3.down * speed * Time.deltaTime;
        rb.velocity = new Vector3(0, -1, 0);
    }
    public void noMove()
    {
        rb.velocity = Vector3.zero;
    }
}
