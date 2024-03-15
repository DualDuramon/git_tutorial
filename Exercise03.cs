using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise03 : MonoBehaviour
{
    //C# 06 연산자s
    private void Awake() {

        int a = 3;                          //0000 0011

        Debug.Log($"{a} << 1 = {a << 1}");  //왼쪽 시프트 연산. 0000 0110
        Debug.Log($"{a} << 2 = {a << 2}");  //0000 1100
        Debug.Log($"{a} << 3 = {a << 3}");  //0001 1000
        Debug.Log($"{a} << 4 = {a << 4}");  //0011 0000

        a = 255;                            //1111 1111
        Debug.Log($"{a} >> 1 = {a >> 1}");  //오른쪽 시프트 연산. 0111 1111
        Debug.Log($"{a} >> 2 = {a >> 2}");  //0011 1111 
        Debug.Log($"{a} >> 3 = {a >> 3}");  //0001 1111
        Debug.Log($"{a} >> 4 = {a >> 4}");  //0000 1111

        a = -255;                           //0000 0001     음수의 시프트는 비트의 빈자리에 1을 넣음.
        Debug.Log($"{a} >> 1 = {a >> 1}");  //1000 0000 
        Debug.Log($"{a} >> 2 = {a >> 2}");  //1100 0000 
        Debug.Log($"{a} >> 3 = {a >> 3}");  //1110 0000
        Debug.Log($"{a} >> 4 = {a >> 4}");  //1111 0000

        Debug.Log(Convert.ToString(a >> 4, 2)); //a를 오른쪽으로 4번 시프트 & 이진수 출력
        Debug.Log($"10 & 6 = {10 & 6}");        // 논리곱 연산자
        Debug.Log($"10 |6 = {10 | 6}");         // 논리합 연산자
        Debug.Log($"10 ^6 = {10 ^ 6}");         // 베타적 논리합 연산자

        Debug.Log($"~10 = {~10}");              //보수 연산자


        /* 04. 논리연산자, 삼항 연산자.
        bool result = false;
        int x = 5, y = 2;

        result = x > 2 && y != 5;                   //&&연산자, 하나라도 거짓이면 false 반환
        Debug.Log($"{x} > 2 && {y} != 5 = {result}");

        result = x < 4 || y == 3 ;                  // ||연산자, 하나라도 참이면 true 반환.
        Debug.Log($"{x} < 4 || {y} == 3 = {result}");

        Debug.Log(result);
        result = !result;           //! 연산자, 참은 거짓, 거짓은 참으로 바꿈
        Debug.Log(result);

        int hp = -10;
        hp = hp < 0 ? 0 : hp;       //삼항연산자
        Debug.Log("체력 : " + hp);
        */

        /*04. 비교 연산자
        int x = 5, y = 2;
        Debug.Log($"{x} > {y} = {x > y}");
        Debug.Log($"{x} < {y} = {x < y}");

        Debug.Log($"{x} >= {y} = {x >= y}");
        Debug.Log($"{x} <= {y} = {x <= y}");

        Debug.Log($"{x} == {y} = {x == y}");
        Debug.Log($"{x} != {y} = {x != y}");
        */

        /*03. 증감 연산자
        int a = 10;
        Debug.Log(a);

        a++;            //후위증가 연산자 : a 반환후 a +1
        Debug.Log(a);

        ++a;            //전위 증가 연산자 : a+1 후 a반환
        Debug.Log(a);

        Debug.Log(a++);     //Debug.Log(a) 실행 후 a+1
        Debug.Log(a);
        Debug.Log(++a);     // a+1 후 Debug.Log(a) 실행
        Debug.Log(a);
        */

        /* 02. 대입(할당)연산자
        int a = 10;
        Debug.Log($"a = 10 : {a}");

        a += 10;
        Debug.Log($"a += 10 : 결과 값{a}");

        Debug.Log($"a -= 9 : 결과 값 {a -= 9}");
        Debug.Log($"a *= 8 : 결과 값 {a *= 8}");
        Debug.Log($"a /= 7 : 결과 값 {a /= 7}");
        Debug.Log($"a %= 6 : 결과 값 {a %= 6}");
        Debug.Log($"a &= 5 : 결과 값 {a &= 5}");
        Debug.Log($"a |= 4 : 결과 값 {a |= 4}");
        Debug.Log($"a ^= 3 : 결과 값 {a ^= 3}");
        Debug.Log($"a <<= 2 : 결과 값 {a <<= 2}");
        Debug.Log($"a >>= 1 : 결과 값 {a >>= 1}");
        */

        /*01. 산술 연산자
        int a = 5 + 6;
        int b = a - 3;
        int c = a * b;
        int d = c / 8;
        int e = d % 4;

        Debug.Log($"{a} = 5 + 6 ");
        Debug.Log($"{b} = {a} - 3 ");
        Debug.Log($"{c} = {a} * {b} ");
        Debug.Log($"{d} = {c} / 8 ");
        Debug.Log($"{e} = {d} % 4 ");
        */
    }

}
