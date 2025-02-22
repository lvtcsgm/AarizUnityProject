using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class camerascript : MonoBehaviour

{
    public float mouseSense = 4.0f;
    public Transform playerBody;
    private float xrotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseControl();   
    }

    void mouseControl()
    {
        float y = Input.GetAxis("Mouse Y")* mouseSense;
        float x = Input.GetAxis("Mouse X")* mouseSense;

        //print(x);
        xrotation -= y;
       
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xrotation,x,0f);

        playerBody.Rotate(Vector3.up * x);
    }



}

