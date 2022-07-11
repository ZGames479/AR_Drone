using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public FixedJoystick fixedJoystick;
    public Rigidbody rb;

    public void Update()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        if(pos.z > 70)
        {
            pos.z = 70;
        }
        else if(pos.z < 0)
        {
            pos.z = 0;
        }

        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * fixedJoystick.Vertical + Vector3.right * fixedJoystick.Horizontal;
        Vector3 newForce = direction * speed * Time.fixedDeltaTime;
        
        if(rb.velocity.magnitude <= 5)
        {
            rb.AddForce(newForce, ForceMode.VelocityChange);
        }
        else
        {
            rb.velocity = rb.velocity.normalized * 5;
        }

        Debug.Log(rb.velocity.magnitude);
    }
}
