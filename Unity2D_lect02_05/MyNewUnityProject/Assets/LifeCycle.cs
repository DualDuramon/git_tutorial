using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //골드메탈 유니티 입문 강좌 B5
    
    void Awake() {  //게임 오브젝트 생성될 때, 최초 1번 실행
        Debug.Log("플레이어의 데이터가 준비되었습니다.");
    }

    void OnEnable() {   //게임 오브젝트가 활성화 되었을때 실행됨
        Debug.Log("플레이어가 로그인 했습니다.");
    }

    void Start() {  //업데이트 시작 직전, 최초 실행
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate() {    //물리연산을 하기 전에 실행, 1초에 50번정도의 고정적 주기로 호출됨 
        Debug.Log("이동하는 중");
    }

    void Update() {
        //물리 연산을 제외한 나머지, 주기적으로 변하는 그런 로직을 넣을때 사용하는 함수
        //실행주기가 실행 환경에 따라 다름. 보통 초당 60번 호출
        Debug.Log("몬스터 사냥");
    }

    void LateUpdate() { //모든 업데이트 함수가 끝나면 실행됨
        Debug.Log("경험치 획득");
    }

    void OnDisable() {  //오브젝트가 비활성화 될 때 실행
        Debug.Log("플레이어가 로그아웃 했습니다.");
    }

    void OnDestroy() { //오브젝트가 삭제되기 직전에 무언가를 남기고 삭제된다는 의미
        Debug.Log("플레이어 데이터를 해제했습니다.");
    }

}
