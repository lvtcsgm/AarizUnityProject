using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int playerhealth = 50;
    public Slider healthSlider;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (healthSlider)
        {
            healthSlider.value = playerhealth;
        }
        
    }
    void damagehealth(int dp)
    {
        playerhealth -= dp;

    }
    void healhealth(int res)
    {
        playerhealth += res;
    }
}
