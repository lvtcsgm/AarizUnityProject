using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 50f;
    public float rotationspeed = 150f;
    public Rigidbody rb;
    public float m_thrust = 20f;
    public float jumptimer;
    private bool onfloor = false;
    private bool touchingfloor = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * vertical + transform.right * horizontal;
        rb.velocity += movement * speed * Time.deltaTime;
        if (Input.GetButtonDown("Jump") && onfloor == true)
        {
            rb.velocity += new Vector3(0, 10, 0);
            rb.AddForce(transform.up * m_thrust);
        }
        
    }
    private void OnCollisionEnter (Collision other)
    {
        print("hitkl");


        if (other.gameObject.tag == "floor")
        {
            onfloor = true;

            print("on the floor");

        }
        //if (other == null);
        //    onfloor = false;
        //    print("Not on floor");
        
        
    }
    public void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "floor")
        {
            onfloor = false;
            print("exiting the floor");
        }
    }
       
  }

