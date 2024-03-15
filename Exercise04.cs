using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Exercise04 : MonoBehaviour
{
    [SerializeField]        //����Ƽ inspectorâ���� ������ �ٲٰ� ���ִ� ��
    private int x = 10;

    private void Awake() {

        int[][] array = new int[3][];       //�ϴ� ���α��� 3��¥�� �迭 ����. �����迭��.
        //int[,] array = new int[3,6];       //2���� �迭 ���� ��

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

        Debug.Log($"�迭�� Ÿ�� : {enemies.GetType()}");
        Debug.Log($"�迭�� �⺻ Ÿ�� : {enemies.GetType().BaseType}");

        Debug.Log("== ���� �� ==");
        for (int index = 0; index < enemies.Length; index++) {
        
            enemies[index] = UnityEngine.Random.Range(0, 100);  // System, UnityEngine �Ѵ� RandomŬ������ ������ �����Ƿ�
            Debug.Log(enemies[index]);                          // ���ӽ����̽� UnityEngine�� �ٿ�����Ѵ�.
        }

        Array.Sort(enemies);        //�Ű������� enemies�迭�� ������ ����.

        Debug.Log("== ���� �� ==");
        for (int index = 0; index < enemies.Length; index++) {
            Debug.Log(enemies[index]);
        }
        */

        /* 06. �ݺ��� ���ѷ���
        int result = 0;
        int index = 1;

        while (true) {
            result += index;
            index++;

            if (index > 100) break;

        }
        */

        /* 05. �ݺ��� - while
        int result = 0;
        int index = 1;

        while (index <= 100) {
            result += index;
            index++;
        }

        Debug.Log($"1���� 100������ ���� {result} �Դϴ�.");
        */

        /* 04. �ݺ��� - for
        for (int idx = 0; idx < 10; idx++) {        // idx ���� : [0, 10);
            Debug.Log(idx);
        }

        for (int x = 1; x < 10; x++) {              //�ݺ��� ��ø
            for (int y = 1; y < 10; y++) {
                Debug.Log($"{x} x {y} = {x * y}");
            }
        }
        */

        /* 03. ���ǹ� - switch
        x /= 10;

        switch (x) {
            case 10:
            case 9:
                Debug.Log("���� : A+");
                break;
            case 8:
                Debug.Log("���� : B+");
                break;
            case 7:
                Debug.Log("���� : C+");
                break;
            case 6:
                Debug.Log("���� : D");
                break;

            default:
                Debug.Log("���� : F");
                break;

        }
        */

        /* 02. ���ǹ� if-else, 
        if (x >= 90) {
            Debug.Log("���� : A+");
        }
        else if(x >= 80) {
            Debug.Log("���� : B+");
        }
        else if (x >= 70) {
            Debug.Log("���� : C+");
        }
        else if (x >= 60) {
            Debug.Log("���� : D");
        }
        else {
            Debug.Log("���� : F");
        }
        */

        /* 01. ���ǹ� if, else
        if (x % 2 == 0) {
            Debug.Log("x�� ¦��");
        }
        else {
            Debug.Log("x�� Ȧ��");
        }

        if (x > 5 && x < 10) {
            Debug.Log("x�� 5���� ũ�� 10���� �۴�");
        }

        if (x > 5) {
            if (x < 10) {   //�������� if �ᵵ ��.
                Debug.Log("x�� 5���� ũ�� 10���� �۴�");
            }
        }

        Debug.Log($"x�� ���� : {x}");
        */
    }
}
