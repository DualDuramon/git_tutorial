using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //C#강좌 11 - 클래스 기초

    /* this()를 이용해 생성자 호출
    public string ID;
    private int currentHP;
    private int currentMP;

    public void TakeDamage(int dmg) {
        if (currentHP > dmg) {
            currentHP -= dmg;
        }
    }

    public Player() {   //기본 생성자
        ID = "Dual";
    }
    public Player(int hp) : this() {    //Player() 호출
        currentHP = hp;
    }
    public Player(int hp, int mp) : this(hp) {  //Player(int hp) 호출
        currentMP = mp;
    }
    */

    /* this 키워드 사용
    public string ID = "Dual";

    public void SetID(string ID) {
        //this.ID = ID;

        Debug.Log($"ID : {ID}");    //매개변수 ID를 가리킴
        Debug.Log($"ID : {this.ID}");
    }
    */

    /* 깊은복사 구현
    public string ID = "Dual";
    private int currentHP = 1000;

    public void TakeDamage(int dmg) {
        if (currentHP > dmg) {
            currentHP -= dmg;
        }
    }

    public Player DeepCopy() {
        Player clone = new Player();
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
    }
    */

    /* 생성자
    public string ID = "Dual";
    private int currentHP = 1000;

    public void TakeDamage(int dmg) {
        if (currentHP > dmg) {
            currentHP -= dmg;
        }
    }

    public Player(string id , int hp) {
        ID = id;
        currentHP = hp;
    }
    */

    /* 소멸자
    ~Player(){ 
        //삭제될 때 따로 실행할 무언가.
    }
    */

    /* 클래스 생성하기
    private string ID = "Dual";
    private int currentHP = 1000;

    public void TakeDamage(int dmg) {
        if (currentHP > dmg) {
            currentHP -= dmg;
        } 
    }
    */
}
