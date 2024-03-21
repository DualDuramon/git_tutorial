using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEntity : MonoBehaviour {

    //C# 강좌 12 - 클래스 심화

    protected int damage;
    protected int currentHp;

    public abstract void Attack(AbstractEntity entity);     //추상메서드라 내용 안적음.
    public void TakeDamage(int dmg) {
        if(currentHp > dmg) {
            currentHp -= dmg;
            Debug.Log($"체력이 {dmg}만큼 감소");
        }
        else {
            Debug.Log("died");
        }
    }

}
