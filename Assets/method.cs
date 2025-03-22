using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator
{
    //¸Þ¼ÒµåÀÇ 
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
}


public class method : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Calculator calculator = new Calculator();

        calculator.Multiple(1, 2);

        int sum = calculator.Add(3, 4);
        Debug.Log($"µ¡¼À °á°ú: {sum}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
