using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour , ImovingEntity, IcombatEntity
{
    //C# ���� 12 - Ŭ���� ��ȭ

    //�������̽� ���߻�� �� ����
    private int damage = 10;

    public void Hit(Entity entitiy) {
        entitiy.TakeDamage(damage);
    }

    public void MoveTo(Vector3 destination) {
        Debug.Log($"{destination} ���� �ɾ �̵���");
    }
    public void Attack(Entity target) {
        Debug.Log($"{target}�� �����մϴ�.");
    }



    /* ���
    public string id;
    protected int currentHp;
    */

    /* ĸ��ȭ�� ��������
    private int currentHP;  //���� ����

    public void SetCurrentHP(int hp) {
        if (hp > 0) {
            currentHP = hp;

        }
    }

    public int GetCurrentHP() {
        return currentHP;
    }
    */
}

/* ���
public class player3 : Player2 {
    private string id;

    public player3(string givenId, int hp) {
        base.id = "Noname";     //�θ𿡰� �������� id ����
        id = givenId;
        currentHp = hp;
    }
}*/