using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{
 private bool canSwing = false;
    private float damage = 5f;
    private float cooldown = 1f;

// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            canSwing = true;
        }

    }
    void Attack()
    {
        canSwing = false;
    }
}
