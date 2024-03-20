using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    //C#강좌 11 - 클래스 기초

    /* 얕은 복사 및 깊은 복사
    private Player p1;
    private Player p2;

    private void Awake() {
        p1 = new Player("Dual", 1000);
        p2 = p1;
        p2.ID = "유니티";

        Debug.Log($"ID : {p1.ID}");
        Debug.Log($"ID : {p2.ID}");
    }
    */

    /*클래스 생성자 호출
    public Player player1;
    public Player player2;

    private void Awake() {
        player1 = new Player();     //클래스의 생성자를 호출해 객체를 만듬
        player1.TakeDamage(100);
        //Player2.TakeDamage(100);  //클래스를 생성해야 메서드 사용 가능
    }
    */
}
