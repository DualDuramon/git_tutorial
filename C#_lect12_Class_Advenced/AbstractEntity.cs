using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEntity : MonoBehaviour {

    //C# ���� 12 - Ŭ���� ��ȭ

    protected int damage;
    protected int currentHp;

    public abstract void Attack(AbstractEntity entity);     //�߻�޼���� ���� ������.
    public void TakeDamage(int dmg) {
        if(currentHp > dmg) {
            currentHp -= dmg;
            Debug.Log($"ü���� {dmg}��ŭ ����");
        }
        else {
            Debug.Log("died");
        }
    }

}
