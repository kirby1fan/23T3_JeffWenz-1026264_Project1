using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour
{

    public int myCurrentHealth = 10;
    public float myMaxHealth = 10;
    //public int myMaxHealth = 10;

    // Start is called before the first frame update
    void Start()
    {
        //below is "out of" version

        Debug.Log("My health is " + myCurrentHealth + "/" + myMaxHealth);
        Debug.Log("I've been hit! Oh no! I have taken 2 damage!!");
        myCurrentHealth -= 2;
        Debug.Log("My health is " + myCurrentHealth + "/" + myMaxHealth);

        //below is percentage version

        myCurrentHealth = 10;
        Debug.Log("My health has been restored and is now " + ((float)myCurrentHealth / (float)myMaxHealth) * 100 + "%");
        //(float)myCurrentHealth - 3.7f; //seeing if I could do dynamic float damage..but it don't work, so seeting back to whole number damage
        myCurrentHealth -= 3;
        Debug.Log("Drat! I've been hit again! Now my health is at " + ((float)myCurrentHealth / (float)myMaxHealth) * 100 + "%");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
