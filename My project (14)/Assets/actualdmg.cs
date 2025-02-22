using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actualdmg : MonoBehaviour
{
    public string enemytag;
    public Rigidbody rb; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag ==enemytag){

            print("hit");

        }
    }
}
