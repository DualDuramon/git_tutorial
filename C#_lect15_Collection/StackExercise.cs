using System.Collections;               //Collection 자료구조들
using System.Collections.Generic;
using UnityEngine;

public class StackExercise : MonoBehaviour
{
    //C# 강좌 15 - Collection
    private void Awake() 
    {
        //생성 및 초기화
        Stack st = new Stack();

        for (int i = 0; i < 5; i++)
            st.Push(i);

        //현재 스택에 있는 요소 개수
        Debug.Log($"Stack.Count : {st.Count}");

        //스택의 최상단 요소 확인
        Debug.Log($"마지막에 추가된 요소 : {st.Peek()}");
        Debug.Log($"Stack.Count : {st.Count}");

        //스택의 최상단 요소 추출
        object data = st.Pop();
        Debug.Log($"스택에서 빠져나온 데이터 : {data}");
        Debug.Log($"Stack.Count : {st.Count}");

        //스택의 모든 요소 삭제
        st.Clear();
        Debug.Log($"Stack.Count : {st.Count}");

    }

}
