using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugging : MonoBehaviour
{
    public string myName = "Jeff Wenz";
    public int myAge = 28;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(myName);
        //Debug.Log(myAge);

        Debug.Log("Hello! My name is "+myName);
        Debug.Log("and I am "+myAge+" years old.");
        myAge = myAge + 1;
        Debug.Log("Next year, I will be " + myAge + " years old.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
