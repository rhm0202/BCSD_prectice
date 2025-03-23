using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//return이란?



public class method : MonoBehaviour
{
    /*
    //메소드의 예
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1}x{num2}={result}");
    }
    */
    //return이란?
    public int Max(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }

        return num2;
    }

    // Start is called before the first frame update
    void Start()
    {
        /*
        //메소드의 예
        Multiple(1, 2);

        int sum = Add(3, 4);
        Debug.Log($"덧셈 결과: {sum}");
        */

        //return이란?
        
        int a = Max(10, 20);
        Debug.Log(Max(100,200));
        Max(5, 10);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
