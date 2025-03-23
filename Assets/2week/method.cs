using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    /*
    //return이란?
    public int Max(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }

        return num2;
    }
    */
    /*
    //값에 의한 전달의 예
    public void Swap(int num1, int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    */
    /*
    //참조에 의한 전달
    public void Swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    */

    //명명된 매게변수
    public void Player(string ID, int health)
    {
        Debug.Log($"ID:{ID}, Hp:{health}");
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
        /*
        //return이란?
        int a = Max(10, 20);
        Debug.Log(Max(100,200));
        Max(5, 10);
        */
        /*
        //값에 의한 전달 예
        int a = 3, b= 4;
        Debug.Log($"Before a = {a}, b={b}");
        Swap(a, b);
        Debug.Log($"After a = {a}, b={b}");
        */
        /*
        //참조에 의한 전달
        int a = 3, b = 4;
        Debug.Log($"Before a = {a}, b={b}");
        Swap(ref a, ref b);
        Debug.Log($"After a = {a}, b={b}");
        */

        //명명된 매개변수
        Player(health: 100, ID: "고박사");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
