using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl2 : MonoBehaviour
{
    //C# ���� 12 - Ŭ���� ��ȭ

    /* �������̽��� �ڽİ�ü ����
    private ImovingEntity goblin;
    private ImovingEntity goblin2;
    private ImovingEntity slime;
    private ImovingEntity butterfly;

    private void Awake() {
        goblin = new Goblin();
        slime = new Slime();
        butterfly = new Butterfly();

        goblin2 = Method();

        goblin.MoveTo(new Vector3(1, 2, 3));
        slime.MoveTo(new Vector3(4, 5, 6));
        butterfly.MoveTo(new Vector3(7, 8, 9));

    }

    private ImovingEntity Method() {
        Goblin goblin2 = new Goblin();
        return goblin2;
    }

    */

    /* ����ȯ ������ is, as
    private void Awake() {
        Entity mob = new Slime();

        if(mob is Slime) {  //mob ��ü�� Slime Ÿ������ bool ������ ��ȯ
            Debug.Log("mob type is Slime");
        }

        Goblin goblin = mob as Goblin;      // mob�� Goblin���� ����ȯ. �����ϸ� null

        if(goblin == null) {
            Debug.Log("goblin is null");
        }
    }
    */

    /* ������-upcasting
    private void Awake() {
        Player2 player = new Player2();

        Entitiy goblin = new Goblin();
        Entitiy slime = new Slime();
        Entitiy dragon = new Dragon();

        player.Hit(goblin);
        player.Hit(slime);
        player.Hit(dragon);
    }
    */

    /* ĸ��ȭ�� ��������
    private void Awake() {
        Player2 player = new Player2();

        // Player2.currentHP = 100;                 //private ������� ����. ������ ����
        //Debug.Log($"HP : {player.currentHP}");

        player.SetCurrentHP(100);                   //ĸ��ȭ
        Debug.Log($"HP : {player.GetCurrentHP()}");
    }
    */
}
