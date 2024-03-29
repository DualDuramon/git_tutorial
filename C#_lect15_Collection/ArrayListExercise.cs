using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class ArrayListExercise : MonoBehaviour
{
    //C# 강좌 15 - Collection

    private void Awake() {
        ArrayList arrayList = new ArrayList();  //생성 및 초기화

        //요소추가 / object타입으로 저장하므로 요소 상관 없음
        Debug.Log(arrayList.Add(10));           //해당 데이터가 저장된 인덱스를 출력
        //Debug.Log(arrayList.Add(12.3f));
        //Debug.Log(arrayList.Add("Hello hi"));

        PrintArrayList(arrayList);      //ArrayList 출력

        arrayList.Insert(1, 100);       //데이터 중간 삽입

        PrintArrayList(arrayList);

        //요소추가- 여러 요소 추가하기
        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);           //Icollection인터페이스 상속받은 객체를 인자로
        
        PrintArrayList(arrayList);

        //데이터 정렬 / 정수 데이터만 있을때만 사용가능 / 그 외 데이터가 있으면 에러 / 오름차순 정렬
        arrayList.Sort();
        PrintArrayList(arrayList);


        //요소 삭제
        arrayList.Remove(10);       //매개변수에 입력된 데이터 삭제
        PrintArrayList(arrayList);

        arrayList.RemoveAt(0);      //매개변수를 인덱스로 가지고 있는 데이터 삭제
        PrintArrayList(arrayList);

        arrayList.RemoveRange(0, 2); // 첫번째 매개변수 위치에서 2번째 매개변수 개수 만큼 삭제
        PrintArrayList(arrayList);

        arrayList.Clear();          //모두 삭제

        Debug.Log(arrayList.Count);
    }

    void PrintArrayList(ArrayList list) {
        Debug.Log("================================");
        for (int i = 0; i < list.Count; i++)  {
            Debug.Log($"list[{i}] = {list[i]}");
        }
    }

}
