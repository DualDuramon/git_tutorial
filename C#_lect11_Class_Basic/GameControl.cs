using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    //C#���� 11 - Ŭ���� ����

    /* ���� ���� �� ���� ����
    private Player p1;
    private Player p2;

    private void Awake() {
        p1 = new Player("Dual", 1000);
        p2 = p1;
        p2.ID = "����Ƽ";

        Debug.Log($"ID : {p1.ID}");
        Debug.Log($"ID : {p2.ID}");
    }
    */

    /*Ŭ���� ������ ȣ��
    public Player player1;
    public Player player2;

    private void Awake() {
        player1 = new Player();     //Ŭ������ �����ڸ� ȣ���� ��ü�� ����
        player1.TakeDamage(100);
        //Player2.TakeDamage(100);  //Ŭ������ �����ؾ� �޼��� ��� ����
    }
    */
}
