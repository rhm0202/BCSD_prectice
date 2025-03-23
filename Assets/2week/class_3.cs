using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Stats
{
    public string ID;
    public int currentHP;
    public int damage;
}

public class class_3 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Stats player01 = new Stats();
        Stats player02;

        player02.ID = "고박사";
        player02.currentHP = 100000;
        player02.damage = 99999;

        Debug.Log($"{player01.ID}, 체력 : {player01.currentHP}, 공격력 : {player01.damage}");
        Debug.Log($"{player02.ID}, 체력 : {player02.currentHP}, 공격력 : {player02.damage}");

        var a = ("고박사", 35);
        Debug.Log($"{a.Item1}, {a.Item2}");

        var a2 = (Name: "고박사", Age: 35);
        Debug.Log($"{a2.Name}, {a2.Age}");

        //var a3 = (Name: "고박사", Age: 35);
        //var (name, age) = a3;
        //Debug.Log($"{name}, {age}");

        var a4 = (Name: "고박사", Age: 35);
        var (name2, _) = a4;
        //Debug.Log($"{name2}, {age}");
        
    }
}
