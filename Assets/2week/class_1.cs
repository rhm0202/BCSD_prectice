//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

////Ŭ������ ��, ���� �������� ��
//public class Player
//{
//    public string ID;
//    private int currentHP;

//    //������
//    public Player()
//    {
//        ID = "��ڻ�";
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

//     //�Ҹ��ڴ� ������� ����
//    void RecoveryHp(int hp) // ���� ������ ������ private�� �⺻
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
//        //player02 = new Player("����Ƽ", 10);
//        player02 = player01.DeepCopy();
//        player02.ID = "����Ƽ";
//        //player01.TakeDamage(100);
//        Debug.Log($"ID: {player01.ID}");
//        Debug.Log($"ID: {player02.ID}");
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
