using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operands : MonoBehaviour
{
    public int numberOne = 3;
    public int numberTwo = 4;
    public int result = 0;
    //public float result = 0f; //that didn't work...

    // Start is called before the first frame update
    void Start()
    {
        // operands are these: + - = / * () %

        // result = numberOne + numberTwo; //basic addition changing result to be 3 + 4 = 7
        // goes through the others in video 2.7
        // dividing INTs cuts off the decimals. use a float instead?
        // result = numberOne / numberTwo; // that didn't work...
        // PEMDAS is real!! Inner most parenthases go first. so something like this would read ( like ( so something ) this )
        // %  is a remainder like 4 can go into 13 3 times (making 12) and 1 would be left over. Thus the answer is 1 (this one seems confusing...)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
