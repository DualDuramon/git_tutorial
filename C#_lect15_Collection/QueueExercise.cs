using System.Collections;               //Collection �ڷᱸ��
using System.Collections.Generic;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{
    //C# ���� 15 - Collection

    private void Awake() {
        Queue que = new Queue();    //ť ���� �� �ʱ�ȭ


        for (int i = 0; i < 5; i++) {   //ť ���� / ���ʿ��� ���Ե�
            que.Enqueue(i);
        }

        //ť�� ����� ��� ���� Ȯ��
        Debug.Log($"Queue.Count : {que.Count}");

        //ť�� �� �� ��� Ȯ��. ���� ����
        Debug.Log($"ť�� �� �� ��� : {que.Peek()}");
        Debug.Log($"Queue.Count : {que.Count}");

        //ť�� �� �� ������ ��������
        object data = que.Dequeue();
        Debug.Log($"ť���� �������� ������ : {data}");
        Debug.Log($"Queue.Count : {que.Count}");

        //ť�� ��� ��� ����
        que.Clear();
        Debug.Log($"Queue.Count : {que.Count}");

    }

}
