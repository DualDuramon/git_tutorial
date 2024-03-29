using System.Collections;               //collection 자료구조
using System.Collections.Generic;
using UnityEngine;

public class HashTableExercise : MonoBehaviour
{
    //C# 강좌 15 - Collection
    private void Awake() {
        
        //해시테이블 생성
        Hashtable hashT = new Hashtable();

        //해시테이블은 object로 저장하기 떄문에 클래스 인스턴스도 저장 가능
        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        //요소 추가 (테이블명[Key] = Value;)
        hashT["Goblin"] = goblin;

        //요소 추가 (Add메서드 이용)
        hashT.Add("Slime", slime);
        hashT.Add(1, "정수");
        hashT.Add(1.2f, "실수");
        hashT.Add("안녕하세요 Dualdura입니다.", "문자열");


        //Hashtable, Dictionary 등과 같이 기존의 for문 사용 못할때
        //그때 쓰는 foreach문
        foreach(object key in hashT.Keys) {
            Debug.Log($"hashT[{key}] = {hashT[key]}");
        }

        //해시 테이블에 해당 key가 존재하는지 확인
        if (hashT.ContainsKey("Slime")) {
            Debug.Log($"Slime 키 존재");
        }

        //해시 테이블에 해당 value가 존재하는지 확인
        if (hashT.ContainsValue(goblin))
            Debug.Log($"{goblin}값 존재");


        //현재 해시테이블에 저장된 요소 개수 확인
        Debug.Log($"Hashtable Count : {hashT.Count}");

        //해시테이블에 해당 키를 가진 요소 삭제
        hashT.Remove("Slime");
        Debug.Log($"Hashtable Count : {hashT.Count}");

        //해시테이블 모든 요소 삭제
        hashT.Clear();
        Debug.Log($"Hashtable Count : {hashT.Count}");
    }

    public class Goblin { }
    public class Slime { }
}
