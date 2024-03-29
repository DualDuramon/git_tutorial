using System.Collections;               //Collection 자료구조
using System.Collections.Generic;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{
    //C# 강좌 15 - Collection

    private void Awake() {
        Queue que = new Queue();    //큐 생성 및 초기화


        for (int i = 0; i < 5; i++) {   //큐 삽입 / 뒤쪽에서 삽입됨
            que.Enqueue(i);
        }

        //큐에 저장된 요소 개수 확인
        Debug.Log($"Queue.Count : {que.Count}");

        //큐의 맨 앞 요소 확인. 삭제 안함
        Debug.Log($"큐의 맨 앞 요소 : {que.Peek()}");
        Debug.Log($"Queue.Count : {que.Count}");

        //큐의 맨 앞 데이터 빼내오기
        object data = que.Dequeue();
        Debug.Log($"큐에서 빠져나온 데이터 : {data}");
        Debug.Log($"Queue.Count : {que.Count}");

        //큐의 모든 요소 삭제
        que.Clear();
        Debug.Log($"Queue.Count : {que.Count}");

    }

}
