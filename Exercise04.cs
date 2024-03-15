using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Exercise04 : MonoBehaviour
{
    [SerializeField]        //유니티 inspector창에서 변수값 바꾸게 해주는 것
    private int x = 10;

    private void Awake() {

        int[][] array = new int[3][];       //일단 세로길이 3줄짜리 배열 선언. 가변배열임.
        //int[,] array = new int[3,6];       //2차원 배열 선언 예

        array[0] = new int[3] { 1, 2, 3 };
        array[1] = new int[] { 10, 20, 30, 40 };
        array[2] = new int[] { 100, 200, 300, 400, 500 };

        for (int i = 0; i < array.Length; i++) {
            for (int j = 0; j < array[i].Length; j++) {
                Debug.Log($"[{i}][{j}] = {array[i][j]}");
            }
        }


        /*
        int[] enemies = new int[5];

        Debug.Log($"배열의 타입 : {enemies.GetType()}");
        Debug.Log($"배열의 기본 타입 : {enemies.GetType().BaseType}");

        Debug.Log("== 정렬 전 ==");
        for (int index = 0; index < enemies.Length; index++) {
        
            enemies[index] = UnityEngine.Random.Range(0, 100);  // System, UnityEngine 둘다 Random클래스를 가지고 있으므로
            Debug.Log(enemies[index]);                          // 네임스페이스 UnityEngine을 붙여줘야한다.
        }

        Array.Sort(enemies);        //매개변수로 enemies배열을 전달해 정렬.

        Debug.Log("== 정렬 후 ==");
        for (int index = 0; index < enemies.Length; index++) {
            Debug.Log(enemies[index]);
        }
        */

        /* 06. 반복문 무한루프
        int result = 0;
        int index = 1;

        while (true) {
            result += index;
            index++;

            if (index > 100) break;

        }
        */

        /* 05. 반복문 - while
        int result = 0;
        int index = 1;

        while (index <= 100) {
            result += index;
            index++;
        }

        Debug.Log($"1부터 100까지의 합은 {result} 입니다.");
        */

        /* 04. 반복문 - for
        for (int idx = 0; idx < 10; idx++) {        // idx 범위 : [0, 10);
            Debug.Log(idx);
        }

        for (int x = 1; x < 10; x++) {              //반복문 중첩
            for (int y = 1; y < 10; y++) {
                Debug.Log($"{x} x {y} = {x * y}");
            }
        }
        */

        /* 03. 조건문 - switch
        x /= 10;

        switch (x) {
            case 10:
            case 9:
                Debug.Log("학점 : A+");
                break;
            case 8:
                Debug.Log("학점 : B+");
                break;
            case 7:
                Debug.Log("학점 : C+");
                break;
            case 6:
                Debug.Log("학점 : D");
                break;

            default:
                Debug.Log("학점 : F");
                break;

        }
        */

        /* 02. 조건문 if-else, 
        if (x >= 90) {
            Debug.Log("학점 : A+");
        }
        else if(x >= 80) {
            Debug.Log("학점 : B+");
        }
        else if (x >= 70) {
            Debug.Log("학점 : C+");
        }
        else if (x >= 60) {
            Debug.Log("학점 : D");
        }
        else {
            Debug.Log("학점 : F");
        }
        */

        /* 01. 조건문 if, else
        if (x % 2 == 0) {
            Debug.Log("x는 짝수");
        }
        else {
            Debug.Log("x는 홀수");
        }

        if (x > 5 && x < 10) {
            Debug.Log("x는 5보다 크고 10보다 작다");
        }

        if (x > 5) {
            if (x < 10) {   //이중으로 if 써도 됨.
                Debug.Log("x는 5보다 크고 10보다 작다");
            }
        }

        Debug.Log($"x의 값은 : {x}");
        */
    }
}
