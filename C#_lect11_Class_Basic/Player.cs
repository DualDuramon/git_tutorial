using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //C#���� 11 - Ŭ���� ����

    /* this()�� �̿��� ������ ȣ��
    public string ID;
    private int currentHP;
    private int currentMP;

    public void TakeDamage(int dmg) {
        if (currentHP > dmg) {
            currentHP -= dmg;
        }
    }

    public Player() {   //�⺻ ������
        ID = "Dual";
    }
    public Player(int hp) : this() {    //Player() ȣ��
        currentHP = hp;
    }
    public Player(int hp, int mp) : this(hp) {  //Player(int hp) ȣ��
        currentMP = mp;
    }
    */

    /* this Ű���� ���
    public string ID = "Dual";

    public void SetID(string ID) {
        //this.ID = ID;

        Debug.Log($"ID : {ID}");    //�Ű����� ID�� ����Ŵ
        Debug.Log($"ID : {this.ID}");
    }
    */

    /* �������� ����
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

    /* ������
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

    /* �Ҹ���
    ~Player(){ 
        //������ �� ���� ������ ����.
    }
    */

    /* Ŭ���� �����ϱ�
    private string ID = "Dual";
    private int currentHP = 1000;

    public void TakeDamage(int dmg) {
        if (currentHP > dmg) {
            currentHP -= dmg;
        } 
    }
    */
}
