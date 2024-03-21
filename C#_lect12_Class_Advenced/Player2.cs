using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour , ImovingEntity, IcombatEntity
{
    //C# 강좌 12 - 클래스 심화

    //인터페이스 다중상속 및 구현
    private int damage = 10;

    public void Hit(Entity entitiy) {
        entitiy.TakeDamage(damage);
    }

    public void MoveTo(Vector3 destination) {
        Debug.Log($"{destination} 까지 걸어서 이동중");
    }
    public void Attack(Entity target) {
        Debug.Log($"{target}을 공격합니다.");
    }



    /* 상속
    public string id;
    protected int currentHp;
    */

    /* 캡슐화와 정보은닉
    private int currentHP;  //정보 은닉

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

/* 상속
public class player3 : Player2 {
    private string id;

    public player3(string givenId, int hp) {
        base.id = "Noname";     //부모에게 물려받은 id 변수
        id = givenId;
        currentHp = hp;
    }
}*/