using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyNameSpace;

public class GameContro3 : MonoBehaviour
{
    //C# ���� 13 - Ŭ���� �߰����
    
    /* namespace ���
    private void Awake() {
        foo foogiman;       //myNameSpace�� using �����Ƿ� �տ� ���� ���ӽ����̽����� ����� ��.
        YourNameSpace.foo foogiman2;
    }
    */

    /*static Ű����
    private void Awake() {
        //static �޼��� ȣ��
        int i = Enemy2.StaticRun();

        Enemy2 enemy01 = new Enemy2();
        int j = enemy01.InstanceRun();

        //int k = enemy01.StaticRun();  //�����޼���� ��ü�� ���� ȣ�� �Ұ�

        //static ������� ���
        Enemy2 enemy02 = new Enemy2();
        enemy02.numeric = 0;
        Enemy2 enemy03 = new Enemy2();
        enemy03.numeric = 1;

        Debug.Log(enemy02.numeric);
        Debug.Log(enemy03.numeric);

        Enemy2.specise = "���";     //�������� ȣ��
        Debug.Log(Enemy2.specise);

        //static Ŭ���� ���
        Debug.Log(Calculator.Sum(10, 20));
        Debug.Log(Calculator.num);

        //Ȯ�� �޼��� ���
        string str = "�ȳ��ϼ���, ���� ��ħ�Դϴ�.";
        str.PrintData(1);
    }
    */

    /* Ʃ�� ���
    private void Awake() {
        var a = ("DualDura", 25);       //Ʃ�� ���� �� Ư�� ���� ����
        Debug.Log($"tuple A : {a.Item1}, {a.Item2}");
        a.Item2 = 26;
        Debug.Log($"tuple A : {a.Item1}, {a.Item2}");

        var b = (Name: "Durara", Age: 7);   //���������� �̸� ���� ����
        Debug.Log($"tuple B :{b.Name}, {b.Age}");

        var (name, age) = b;        //Ʃ�ÿ��� ������ ������ �����ؼ� ��� ����
        Debug.Log($"{name}, {age}");

        var c = (myName: "Dururu", oldAge: 14);    //Ʃ�� ���ؽ� _ ���� �ش� �ʵ� ����
        var (yourName, _) = c;
        //Debug.Log($"{yourName},{oldAge}");        //oldAge ���� ������ ����
    }
    */

    /* ����ü ����ϱ�
    private void Awake() {

        Stats player01 = new Stats();
        Stats player02;

        player02.ID = "DualDura";
        player02.currentHp = 100000;
        player02.damage = 91001;

        Debug.Log($"{player01.ID}, HP : {player01.currentHp} / ���ݷ� : {player01.damage}");
        Debug.Log($"{player02.ID}, HP : {player02.currentHp} / ���ݷ� : {player02.damage}");  
    }*/


    /* �޼ҵ� �����.
    private void Awake() {
        Parent p = new Parent();
        p.Method01();

        Child c = new Child();
        c.Method01();

        Parent pc = new Child();    //�޼ҵ� �������̵��� �ٸ��� Parent�� �޼��� ȣ��
        pc.Method01();
    }*/
}
