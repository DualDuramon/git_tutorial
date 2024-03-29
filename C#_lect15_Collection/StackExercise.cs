using System.Collections;               //Collection �ڷᱸ����
using System.Collections.Generic;
using UnityEngine;

public class StackExercise : MonoBehaviour
{
    //C# ���� 15 - Collection
    private void Awake() 
    {
        //���� �� �ʱ�ȭ
        Stack st = new Stack();

        for (int i = 0; i < 5; i++)
            st.Push(i);

        //���� ���ÿ� �ִ� ��� ����
        Debug.Log($"Stack.Count : {st.Count}");

        //������ �ֻ�� ��� Ȯ��
        Debug.Log($"�������� �߰��� ��� : {st.Peek()}");
        Debug.Log($"Stack.Count : {st.Count}");

        //������ �ֻ�� ��� ����
        object data = st.Pop();
        Debug.Log($"���ÿ��� �������� ������ : {data}");
        Debug.Log($"Stack.Count : {st.Count}");

        //������ ��� ��� ����
        st.Clear();
        Debug.Log($"Stack.Count : {st.Count}");

    }

}
