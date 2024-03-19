using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise05 : MonoBehaviour
{
    //고박사 C# 강좌 #10 메서드
    /* 선택적 매개변수
    private void Player(String id = "Myname", int health = 1000) {
        Debug.Log($"ID : {id} / HP : {health}");
    }
    private void Player() {
        Debug.Log("ID 와 HP를 입력해 주세요.");
    }

    private void Awake() {
        Player("DualDura");
        Player("DualDura", 1000);
    }
    */

    /* 명명된 매개변수
    private void Player(String id, int health) {
        Debug.Log($"ID : {id} / HP : {health}");
    }

    private void Awake() {
        Player(id: "DualDura", health: 100);
        Player(health: 100, id: "DualDura");
    }
    */

    /* 메서드 오버로딩
    private void Awake() {
        Add(10, 20);
        Add(10.28f, 17.45f);
    }

    public void Add(int n1, int n2) {
        int result = n1 + n2;
        Debug.Log($"{n1} + {n2} = {result}");
    }
    public void Add(float n1, float n2) {
        float result = n1 + n2;
        Debug.Log($"{n1} + {n2} = {result}");
    }
    */

    /* 참조에 의한 전달 방식
    private void Awake() {
        int a = 3, b = 4;
        Debug.Log($"a = {a} , b = {b}");
        Swap(ref a, ref b);
    }

    public void Swap(ref int num1, ref int num2) {
        int tmp = num1;
        num1 = num2;
        num2 = tmp;
    }
    */

    /* 값에 의한 전달 방식
    private void Awake() {
        int a = 3, b = 4;
        Add(a, b);
    }

    private void Add(int num1, int num2) {
        int result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");
    }
    */
}
