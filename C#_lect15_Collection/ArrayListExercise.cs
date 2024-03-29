using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class ArrayListExercise : MonoBehaviour
{
    //C# ���� 15 - Collection

    private void Awake() {
        ArrayList arrayList = new ArrayList();  //���� �� �ʱ�ȭ

        //����߰� / objectŸ������ �����ϹǷ� ��� ��� ����
        Debug.Log(arrayList.Add(10));           //�ش� �����Ͱ� ����� �ε����� ���
        //Debug.Log(arrayList.Add(12.3f));
        //Debug.Log(arrayList.Add("Hello hi"));

        PrintArrayList(arrayList);      //ArrayList ���

        arrayList.Insert(1, 100);       //������ �߰� ����

        PrintArrayList(arrayList);

        //����߰�- ���� ��� �߰��ϱ�
        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);           //Icollection�������̽� ��ӹ��� ��ü�� ���ڷ�
        
        PrintArrayList(arrayList);

        //������ ���� / ���� �����͸� �������� ��밡�� / �� �� �����Ͱ� ������ ���� / �������� ����
        arrayList.Sort();
        PrintArrayList(arrayList);


        //��� ����
        arrayList.Remove(10);       //�Ű������� �Էµ� ������ ����
        PrintArrayList(arrayList);

        arrayList.RemoveAt(0);      //�Ű������� �ε����� ������ �ִ� ������ ����
        PrintArrayList(arrayList);

        arrayList.RemoveRange(0, 2); // ù��° �Ű����� ��ġ���� 2��° �Ű����� ���� ��ŭ ����
        PrintArrayList(arrayList);

        arrayList.Clear();          //��� ����

        Debug.Log(arrayList.Count);
    }

    void PrintArrayList(ArrayList list) {
        Debug.Log("================================");
        for (int i = 0; i < list.Count; i++)  {
            Debug.Log($"list[{i}] = {list[i]}");
        }
    }

}
