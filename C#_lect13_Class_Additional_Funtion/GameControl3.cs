using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyNameSpace;

public class GameContro3 : MonoBehaviour
{
    //C# 강좌 13 - 클래스 추가기능
    
    /* namespace 사용
    private void Awake() {
        foo foogiman;       //myNameSpace를 using 했으므로 앞에 따로 네임스패이스명을 안적어도 됨.
        YourNameSpace.foo foogiman2;
    }
    */

    /*static 키워드
    private void Awake() {
        //static 메서드 호출
        int i = Enemy2.StaticRun();

        Enemy2 enemy01 = new Enemy2();
        int j = enemy01.InstanceRun();

        //int k = enemy01.StaticRun();  //정적메서드는 객체에 의해 호출 불가

        //static 멤버변수 사용
        Enemy2 enemy02 = new Enemy2();
        enemy02.numeric = 0;
        Enemy2 enemy03 = new Enemy2();
        enemy03.numeric = 1;

        Debug.Log(enemy02.numeric);
        Debug.Log(enemy03.numeric);

        Enemy2.specise = "고블린";     //정적변수 호출
        Debug.Log(Enemy2.specise);

        //static 클래스 사용
        Debug.Log(Calculator.Sum(10, 20));
        Debug.Log(Calculator.num);

        //확장 메서드 사용
        string str = "안녕하세요, 좋은 아침입니다.";
        str.PrintData(1);
    }
    */

    /* 튜플 사용
    private void Awake() {
        var a = ("DualDura", 25);       //튜플 생성 및 특정 변수 수정
        Debug.Log($"tuple A : {a.Item1}, {a.Item2}");
        a.Item2 = 26;
        Debug.Log($"tuple A : {a.Item1}, {a.Item2}");

        var b = (Name: "Durara", Age: 7);   //내부적으로 이름 설정 가능
        Debug.Log($"tuple B :{b.Name}, {b.Age}");

        var (name, age) = b;        //튜플에서 데이터 가져와 분해해서 사용 가능
        Debug.Log($"{name}, {age}");

        var c = (myName: "Dururu", oldAge: 14);    //튜플 분해시 _ 쓰면 해당 필드 무시
        var (yourName, _) = c;
        //Debug.Log($"{yourName},{oldAge}");        //oldAge 변수 때문에 에러
    }
    */

    /* 구조체 사용하기
    private void Awake() {

        Stats player01 = new Stats();
        Stats player02;

        player02.ID = "DualDura";
        player02.currentHp = 100000;
        player02.damage = 91001;

        Debug.Log($"{player01.ID}, HP : {player01.currentHp} / 공격력 : {player01.damage}");
        Debug.Log($"{player02.ID}, HP : {player02.currentHp} / 공격력 : {player02.damage}");  
    }*/


    /* 메소드 숨기기.
    private void Awake() {
        Parent p = new Parent();
        p.Method01();

        Child c = new Child();
        c.Method01();

        Parent pc = new Child();    //메소드 오버라이딩과 다르게 Parent의 메서드 호출
        pc.Method01();
    }*/
}
