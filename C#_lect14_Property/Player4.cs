using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4 : BaseEntity {
    //C#강좌 14 - 프로퍼티

    // 추상 클래스 프로퍼티 구현
    public override int Shield {  //추상 프로퍼티 구현
        get; set;
    }
    public string ID {
        get; set;
    }

    /* 생성자 없이 프로퍼티 호출
    public int CurrentHp {
        get; set;
    }
    public string ID {
        get; set;
    }
    */

    /* 읽기/쓰기전용 프로퍼티
    private int currentHp;
    public int CurrentHp {  //읽기 전용 프로퍼티
        get => currentHp;
    }

    private int currentMp;
    public int CurrentMp {  //쓰기 전용 프로퍼티
        set => currentMp = value;
    }

    private string Id;
    public string ID {  //접근 지정자 사용
        get => Id;
        private set {   //클래스 내부에서만 set 사용 가능
            Id = value;
        }
    }
    */
    /* 자동구현 프로퍼티
    public int CurrentHp {  //자동구현 프로퍼티. 변수를 따로 정의 안해도 됨
        get; set;
    }
    public string Id {
        get; set;
    }
    */

    /* 프로퍼티 설정
    private int currentHp;
    public int CurrentHp {
        get => currentHp;   //내용이 한줄이라면 => 사용
        set {               //내용이 여러줄이면 중괄호 사용
            if (value > 0) {
                currentHp = value;
            }
            else {
                currentHp = 0;
            }
        }
    }
    */
}
