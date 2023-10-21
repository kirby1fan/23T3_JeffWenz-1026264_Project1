using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(5 > 3)
        {
            Debug.Log("Five is greater than three");
        }
        if(3 < 5)
        {
            Debug.Log("Three is less than five");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
