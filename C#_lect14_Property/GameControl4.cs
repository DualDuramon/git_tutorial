using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl4:MonoBehaviour
{
    //C#���� 14 - ������Ƽ

    /* �߻� ������Ƽ
    private void Awake() {
        Player4 player = new Player4() {
            //player4�� �� 3���� ������Ƽ�� ����� �� ����.
            ID = "dual",
            Shield = 50,
            Defense = 10
        };

        Debug.Log($"ID : {player.ID}");
        Debug.Log($"���� : {player.Defense}, ���� : {player.Shield}");
    }
    */
    /* ������ ���� ������Ƽ ȣ��
    private void Awake() {
        Player4 player = new Player4() {
            CurrentHp = 100,
            ID = "Dualdura"
        };
    }
    */
    /* �ڵ����� ������Ƽ ȣ��
    private void Awake() {
        Player4 player = new Player4();
        player.Id = "dualdura";
        player.CurrentHp = 100;

        Debug.Log($"{player.Id}'s HP: {player.CurrentHp}");
    }
    */
    /* ������Ƽ ȣ��
    private void Awake() {
        Player4 player = new Player4();
        player.CurrentHp = 100;                         //set������Ƽ ȣ��.
        Debug.Log($"Player HP : {player.CurrentHp}");   //get ������Ƽ ȣ��
        player.CurrentHp = -100;
        Debug.Log($"Player HP : {player.CurrentHp}");
    }
    */
}
