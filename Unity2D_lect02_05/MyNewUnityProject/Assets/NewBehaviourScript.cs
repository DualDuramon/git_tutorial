using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //골드메탈 유니티입문강좌 B4
    
    string title = "전설의";
    string playerName = "DualDura"; 
    int level = 5;
    float strength = 15.5f;
    int exp = 1500;
    int health = 30;
    int mana = 25;
    bool isFullLevel = false;

    void Start()
    {
        Debug.Log("Hello Unity!");

        //1. 변수
        //int level = 5;                  //정수형
        //float strength = 15.5f;         //실수형
        //string playerName = "DualDura"; //문자형
        //bool isFullLevel = false;       //논리형
        /*
        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);
        */
        
        //2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };

        /*
        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]); 
        Debug.Log(monsters[1]); 
        Debug.Log(monsters[2]);
        */

        int[] monstersLevel = new int[3];
        monstersLevel[0] = 1;
        monstersLevel[1] = 6;
        monstersLevel[2] = 20;


        /*
        Debug.Log("맵에 존재하는 몬스터 레벨");
        Debug.Log(monstersLevel[0]);
        Debug.Log(monstersLevel[1]);
        Debug.Log(monstersLevel[2]);
        */

        List<string> items = new List<string>();    //지네릭스
        items.Add("생명물약30");
        items.Add("마나물약30");

        /*
        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(0);

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);                //요소가 없는 인덱스 접근->에러
        Debug.Log(items[1]);   
        */

        //3. 연산자
        //int exp = 1500;

        exp = 1500 + 320;               //사칙연산
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);    //나머지 출력
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        //string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " "+playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;  //비교연산자
        Debug.Log("용사는 만렙입니까? " + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

        //int health = 30;
        //int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;       //end 연산자
        bool isBadCondition = health <= 50 || mana <= 20;         //or 연산자
        //Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";        //삼항연산자
        Debug.Log("용사의 상태가 나쁩니까? " + condition);

        //4. 키워드 : 프로그래밍 언어를 구성하는 특별한 단어. 변수 이름으로 사용할 수 없음.
        //int flaot = 0; string bool = false;

        //5. 조건문
        if (condition == "나쁨") {
            Debug.Log("플레이어의 상태가 나쁘니 아이템을 사용하세요");
        }
        else {
            Debug.Log("플레이어의 상태가 좋습니다");
        }

        if (isBadCondition && items[0] == "생명물약30") {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용했습니다");
        }
        else if(isBadCondition && items[0] == "마나물약30") {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용했습니다");
        }

        string monsterAlarm;
        switch (monsters[0]) {
            case "슬라임": case "사막뱀":
                monsterAlarm = "소형 몬스터 출현!";
                break;
            case "악마":
                monsterAlarm = "중형 몬스터 출현!";
                break;
            case "골렘":
                monsterAlarm = "대형 몬스터 출현!";
                break;
            default:
                monsterAlarm = "??? 몬스터 출현!";
                break;
        }
        Debug.Log(monsterAlarm);

        //6. 반목분
        while(health > 0) {
            health--;

            if (health > 0)
                Debug.Log("독 데미지를 입었습니다 " + health);
            else
                Debug.Log("사망했습니다.");

            if (health == 10) {
                Debug.Log("해독제를 사용합니다");
                break;
            }
        }

        for (int count = 0; count < 10; count++) {
            health++;
            //Debug.Log("붕대감는중... " + health);
        }

        for (int idx = 0; idx < monsters.Length; idx++) {
            //Debug.Log("이 지역에 있는 몬스터 : " + monsters[idx]);
        }

        foreach (string monster in monsters) {
            Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }

        //7. 함수(메서드)
        //health = Heal(health);
        
        Heal();
        for (int idx = 0; idx < monsters.Length; idx++) {
            Debug.Log("용사는 " + monsters[idx] + "에게 " + Battle(monstersLevel[idx]));
        }

        //8. 클래스
        Player player = new Player();         //인스턴스화
        player.id = 0;
        player.name = "법사다";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");
        Debug.Log(player.move());

    }// end of start()

    //7.함수(메서드)
    int Heal(int currentHealth) {
        currentHealth += 10;
        Debug.Log("힐을 받았습니다. " + currentHealth);
        return currentHealth;
    }

    void Heal() {
        health += 10;
        Debug.Log("힐을 받았습니다. " + health);

    }

    string Battle(int monsterLevel) {
        string result;
        if (level >= monsterLevel) {
            result = "이겼습니다.";
        }
        else {
            result = "패배했습니다.";
        }

        return result;
    }

}
