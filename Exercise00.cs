using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise00 : MonoBehaviour
{
    /*
    //���� ���� �� �ʱ�ȭ�� ���.
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

    private int currentHP = 10;         //Ŭ���� �ɹ� ����
    private readonly int maxHP = 100;   //�б� ���� ����
    private const int maxMP = 100;      // ���

    public Exercise00() {   //Ŭ���� ������
        maxHP = 200;        //readonly ������ ���� �ʱ�ȭ �Ҷ��� �����ڿ����� ���� ����
    }


    private void Awake() {
        int currentMP = 50;     //��������, �Լ� ������ �Ҹ�

        currentHP = 100;
        //maxHP = 300;          //readonly ������ const ����� ���� �Ұ�
        //maxMP = 200;

        Debug.Log("currentHP: " + currentHP);
        Debug.Log("currentMP: " + currentMP);
        Debug.Log("maxHP: "+ maxHP);
    }

    private void Update() {
        //currentMP = 150;      //currentMP�� ���������̹Ƿ� Awake()�� ������Ƿ� Update()���� ��� �Ұ�
    }
}
