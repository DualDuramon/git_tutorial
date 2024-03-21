using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl2 : MonoBehaviour
{
    //C# 강좌 12 - 클래스 심화

    /* 인터페이스로 자식객체 생성
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

    /* 형변환 연산자 is, as
    private void Awake() {
        Entity mob = new Slime();

        if(mob is Slime) {  //mob 객체가 Slime 타입인지 bool 값으로 반환
            Debug.Log("mob type is Slime");
        }

        Goblin goblin = mob as Goblin;      // mob을 Goblin으로 형변환. 실패하면 null

        if(goblin == null) {
            Debug.Log("goblin is null");
        }
    }
    */

    /* 다형성-upcasting
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

    /* 캡슐화와 정보은닉
    private void Awake() {
        Player2 player = new Player2();

        // Player2.currentHP = 100;                 //private 멤버변수 접근. 컴파일 에러
        //Debug.Log($"HP : {player.currentHP}");

        player.SetCurrentHP(100);                   //캡슐화
        Debug.Log($"HP : {player.GetCurrentHP()}");
    }
    */
}
