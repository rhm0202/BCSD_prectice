using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
// ĸ��ȭ ��
public class Player
{
    private int currentHP;

    public void SetCurrentHP(int hp)
    {
        if (hp > 0)
        {
            currentHP = hp;
        }
    }
    public int GetCurrentHP()
    {
        return currentHP;
    }
}
*/
/*
//��� ��
public class Entity
{
    public string ID;
    protected int currentHP;

    //private void Initialize()
    //{
    //    ID = "Nomame";
    //}

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
}

public class Player:Entity
{
    private string ID;

    public Player(string id, int hp)
    {
        base.ID = "Nomame";
        ID = id;
        currentHP = hp;

        RecoveryHP(1000);

        //Initialize();
    }
}
*/
/*
//������

public class Entity
{
    public void Attact()
    {
        Debug.Log("���� �����Ѵ�.");
    }

    public virtual void Heal()
    {
        Debug.Log("ä���� ȸ���Ѵ�.");
    }
}

public class Goblin : Entity
{
    public void Avoid()
    {
        Debug.Log("��������!!");
    }
    public override void Heal()
    {
        Debug.Log("����� ü�� ȸ��!");
    }
}
*/
/*
//�߻� Ŭ����
public abstract class Entity
{
    protected int damage;
    protected int currentHP;

    public abstract void Attact(Entity target);

    public virtual void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
            Debug.Log($"ü���� {damage} ����");
        }
        else
        {
            Debug.Log("Die");
        }
    }
}
public class Goblin : Entity
{
    public Goblin(int damage, int hp) 
    {
        base.damage = damage;
        currentHP = hp; 
    }
    public override void Attact(Entity target)
    {
        Debug.Log("����� ������ ���Ž�!");
        target.TakeDamage(damage);
    }
}

public class Slime : Entity
{
    public Slime(int damage, int hp)
    {
        base.damage = damage;
        currentHP = hp;
    }
    public override void Attact(Entity target)
    {
        Debug.Log("�������� �����ġ��!");
        target.TakeDamage(damage);
    }
}
*/
/*
//�������̽��� ��
interface IMovingEntity
{
    void MoveTo(Vector3 destination);

}*/
/*
public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� �ɾ �̵�");
    }
}
public class Slime : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� �� �̵�");
    }
}
public class Butterfly : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� ���Ƽ� �̵�");
    }
}
*/
/*
public class class_2 : MonoBehaviour
{
    /*
    public Entity entity;
    public Entity goblin;
    public Entity slime;
    

    private IMovingEntity goblin;
    private IMovingEntity slime;
    private IMovingEntity butterfly;

    // Start is called before the first frame update
    private void Awake()
    {
        /*
        Player player = new Player();

        player.SetCurrentHP(100);
        Debug.Log($"HP: {player.GetCurrentHP()}");
        */
        /*
        Entity entity1 = new Entity();

        entity1.Attact();
        entity1.Heal();

        Goblin goblin = new Goblin();

        goblin.Attact();
        goblin.Heal();
        goblin.Avoid();

        Entity entity2 = new Goblin();
        entity2.Attact();
        entity2.Heal();
        */
        /*
        //entity = new Entity();
        goblin = new Goblin(5, 100);
        slime = new Slime(10, 50);

        goblin.Attact(slime);
        slime.Attact(goblin);
        */
        /*
        goblin = new Goblin();
        slime = new Slime();
        butterfly = new Butterfly();

        goblin.MoveTo(new Vector3(1, 2, 3));
        slime.MoveTo(new Vector3 (4, 5, 6));
        butterfly.MoveTo(new Vector3 (7,8, 9));

    }
}
*/