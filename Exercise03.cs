using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise03 : MonoBehaviour
{
    //C# 06 ������s
    private void Awake() {

        int a = 3;                          //0000 0011

        Debug.Log($"{a} << 1 = {a << 1}");  //���� ����Ʈ ����. 0000 0110
        Debug.Log($"{a} << 2 = {a << 2}");  //0000 1100
        Debug.Log($"{a} << 3 = {a << 3}");  //0001 1000
        Debug.Log($"{a} << 4 = {a << 4}");  //0011 0000

        a = 255;                            //1111 1111
        Debug.Log($"{a} >> 1 = {a >> 1}");  //������ ����Ʈ ����. 0111 1111
        Debug.Log($"{a} >> 2 = {a >> 2}");  //0011 1111 
        Debug.Log($"{a} >> 3 = {a >> 3}");  //0001 1111
        Debug.Log($"{a} >> 4 = {a >> 4}");  //0000 1111

        a = -255;                           //0000 0001     ������ ����Ʈ�� ��Ʈ�� ���ڸ��� 1�� ����.
        Debug.Log($"{a} >> 1 = {a >> 1}");  //1000 0000 
        Debug.Log($"{a} >> 2 = {a >> 2}");  //1100 0000 
        Debug.Log($"{a} >> 3 = {a >> 3}");  //1110 0000
        Debug.Log($"{a} >> 4 = {a >> 4}");  //1111 0000

        Debug.Log(Convert.ToString(a >> 4, 2)); //a�� ���������� 4�� ����Ʈ & ������ ���
        Debug.Log($"10 & 6 = {10 & 6}");        // ���� ������
        Debug.Log($"10 |6 = {10 | 6}");         // ���� ������
        Debug.Log($"10 ^6 = {10 ^ 6}");         // ��Ÿ�� ���� ������

        Debug.Log($"~10 = {~10}");              //���� ������


        /* 04. ��������, ���� ������.
        bool result = false;
        int x = 5, y = 2;

        result = x > 2 && y != 5;                   //&&������, �ϳ��� �����̸� false ��ȯ
        Debug.Log($"{x} > 2 && {y} != 5 = {result}");

        result = x < 4 || y == 3 ;                  // ||������, �ϳ��� ���̸� true ��ȯ.
        Debug.Log($"{x} < 4 || {y} == 3 = {result}");

        Debug.Log(result);
        result = !result;           //! ������, ���� ����, ������ ������ �ٲ�
        Debug.Log(result);

        int hp = -10;
        hp = hp < 0 ? 0 : hp;       //���׿�����
        Debug.Log("ü�� : " + hp);
        */

        /*04. �� ������
        int x = 5, y = 2;
        Debug.Log($"{x} > {y} = {x > y}");
        Debug.Log($"{x} < {y} = {x < y}");

        Debug.Log($"{x} >= {y} = {x >= y}");
        Debug.Log($"{x} <= {y} = {x <= y}");

        Debug.Log($"{x} == {y} = {x == y}");
        Debug.Log($"{x} != {y} = {x != y}");
        */

        /*03. ���� ������
        int a = 10;
        Debug.Log(a);

        a++;            //�������� ������ : a ��ȯ�� a +1
        Debug.Log(a);

        ++a;            //���� ���� ������ : a+1 �� a��ȯ
        Debug.Log(a);

        Debug.Log(a++);     //Debug.Log(a) ���� �� a+1
        Debug.Log(a);
        Debug.Log(++a);     // a+1 �� Debug.Log(a) ����
        Debug.Log(a);
        */

        /* 02. ����(�Ҵ�)������
        int a = 10;
        Debug.Log($"a = 10 : {a}");

        a += 10;
        Debug.Log($"a += 10 : ��� ��{a}");

        Debug.Log($"a -= 9 : ��� �� {a -= 9}");
        Debug.Log($"a *= 8 : ��� �� {a *= 8}");
        Debug.Log($"a /= 7 : ��� �� {a /= 7}");
        Debug.Log($"a %= 6 : ��� �� {a %= 6}");
        Debug.Log($"a &= 5 : ��� �� {a &= 5}");
        Debug.Log($"a |= 4 : ��� �� {a |= 4}");
        Debug.Log($"a ^= 3 : ��� �� {a ^= 3}");
        Debug.Log($"a <<= 2 : ��� �� {a <<= 2}");
        Debug.Log($"a >>= 1 : ��� �� {a >>= 1}");
        */

        /*01. ��� ������
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
