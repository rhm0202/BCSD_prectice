using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class method : MonoBehaviour
{
    /*
    //�޼ҵ��� ��
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
    //return�̶�?
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
    //���� ���� ������ ��
    public void Swap(int num1, int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    */
    /*
    //������ ���� ����
    public void Swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    */

    //���� �ŰԺ���
    public void Player(string ID, int health)
    {
        Debug.Log($"ID:{ID}, Hp:{health}");
    }

    // Start is called before the first frame update
    void Start()
    {
        /*
        //�޼ҵ��� ��
        Multiple(1, 2);

        int sum = Add(3, 4);
        Debug.Log($"���� ���: {sum}");
        */
        /*
        //return�̶�?
        int a = Max(10, 20);
        Debug.Log(Max(100,200));
        Max(5, 10);
        */
        /*
        //���� ���� ���� ��
        int a = 3, b= 4;
        Debug.Log($"Before a = {a}, b={b}");
        Swap(a, b);
        Debug.Log($"After a = {a}, b={b}");
        */
        /*
        //������ ���� ����
        int a = 3, b = 4;
        Debug.Log($"Before a = {a}, b={b}");
        Swap(ref a, ref b);
        Debug.Log($"After a = {a}, b={b}");
        */

        //���� �Ű�����
        Player(health: 100, ID: "��ڻ�");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
