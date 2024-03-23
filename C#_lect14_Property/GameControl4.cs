using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl4:MonoBehaviour
{
    //C#강좌 14 - 프로퍼티

    /* 추상 프로퍼티
    private void Awake() {
        Player4 player = new Player4() {
            //player4는 총 3개의 프로퍼티를 사용할 수 있음.
            ID = "dual",
            Shield = 50,
            Defense = 10
        };

        Debug.Log($"ID : {player.ID}");
        Debug.Log($"방어력 : {player.Defense}, 쉴드 : {player.Shield}");
    }
    */
    /* 생성자 없이 프로퍼티 호출
    private void Awake() {
        Player4 player = new Player4() {
            CurrentHp = 100,
            ID = "Dualdura"
        };
    }
    */
    /* 자동구현 프로퍼티 호출
    private void Awake() {
        Player4 player = new Player4();
        player.Id = "dualdura";
        player.CurrentHp = 100;

        Debug.Log($"{player.Id}'s HP: {player.CurrentHp}");
    }
    */
    /* 프로퍼티 호출
    private void Awake() {
        Player4 player = new Player4();
        player.CurrentHp = 100;                         //set프로퍼티 호출.
        Debug.Log($"Player HP : {player.CurrentHp}");   //get 프로퍼티 호출
        player.CurrentHp = -100;
        Debug.Log($"Player HP : {player.CurrentHp}");
    }
    */
}
