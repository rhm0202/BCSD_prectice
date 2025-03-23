//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

////클래스의 예, 접근 지정자의 예
//public class Player
//{
//    public string ID;
//    private int currentHP;

//    //생성자
//    public Player()
//    {
//        ID = "고박사";
//        currentHP = 1000;
//    }

//    public Player(string ID, int hp)
//    {
//        this.ID = ID;
//        this.currentHP = hp;
//    }

//    public Player DeepCopy()
//    {
        
//        Player clone = new Player();
//        clone.ID = ID;
//        clone.currentHP = currentHP;

//        return clone;
//    }

//     //소멸자는 사용하지 않음
//    void RecoveryHp(int hp) // 접근 지정자 생략시 private가 기본
//    {
//        currentHP += hp;
//    }

//    public void TakeDamage(int damage)
//    {
//        if(currentHP > damage)
//        {
//            currentHP -= damage;
//        }
//    }
//}

//public class Enemy
//{
//    private Player player;

//    public void AttackToTarget(Player target)
//    {
//        target.TakeDamage(100);
//    }
//}

//public class class_1 : MonoBehaviour
//{
//    public Player player01;
//    public Player player02;

//    // Start is called before the first frame update
//    private void Awake()
//    {
//        player01 = new Player();
//        //player02 = new Player("유니티", 10);
//        player02 = player01.DeepCopy();
//        player02.ID = "유니티";
//        //player01.TakeDamage(100);
//        Debug.Log($"ID: {player01.ID}");
//        Debug.Log($"ID: {player02.ID}");
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
