using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise00 : MonoBehaviour
{
    /*
    //변수 생성 및 초기화의 방법.
    private int value01;
    private int value02, value03, value04;
    private int value05 = 5;
    private int value06 = 10, value07 = 20, value08 = 30;


    // Start is called before the first frame update
    private void Awake()
    {
        value01 = 1;
        value02 = 2;
        value03 = 3;
        value04 = 4;
    }
    */

    private int currentHP = 10;         //클레스 맴버 변수
    private readonly int maxHP = 100;   //읽기 전용 변수
    private const int maxMP = 100;      // 상수

    public Exercise00() {   //클래스 생성자
        maxHP = 200;        //readonly 변수는 변수 초기화 할때랑 생성자에서만 수정 가능
    }


    private void Awake() {
        int currentMP = 50;     //지역변수, 함수 끝나면 소멸

        currentHP = 100;
        //maxHP = 300;          //readonly 변수와 const 상수는 수정 불가
        //maxMP = 200;

        Debug.Log("currentHP: " + currentHP);
        Debug.Log("currentMP: " + currentMP);
        Debug.Log("maxHP: "+ maxHP);
    }

    private void Update() {
        //currentMP = 150;      //currentMP는 지역변수이므로 Awake()를 벗어났으므로 Update()에선 사용 불가
    }
}
