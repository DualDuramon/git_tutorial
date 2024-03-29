using System.Collections;               //collection �ڷᱸ��
using System.Collections.Generic;
using UnityEngine;

public class HashTableExercise : MonoBehaviour
{
    //C# ���� 15 - Collection
    private void Awake() {
        
        //�ؽ����̺� ����
        Hashtable hashT = new Hashtable();

        //�ؽ����̺��� object�� �����ϱ� ������ Ŭ���� �ν��Ͻ��� ���� ����
        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        //��� �߰� (���̺��[Key] = Value;)
        hashT["Goblin"] = goblin;

        //��� �߰� (Add�޼��� �̿�)
        hashT.Add("Slime", slime);
        hashT.Add(1, "����");
        hashT.Add(1.2f, "�Ǽ�");
        hashT.Add("�ȳ��ϼ��� Dualdura�Դϴ�.", "���ڿ�");


        //Hashtable, Dictionary ��� ���� ������ for�� ��� ���Ҷ�
        //�׶� ���� foreach��
        foreach(object key in hashT.Keys) {
            Debug.Log($"hashT[{key}] = {hashT[key]}");
        }

        //�ؽ� ���̺� �ش� key�� �����ϴ��� Ȯ��
        if (hashT.ContainsKey("Slime")) {
            Debug.Log($"Slime Ű ����");
        }

        //�ؽ� ���̺� �ش� value�� �����ϴ��� Ȯ��
        if (hashT.ContainsValue(goblin))
            Debug.Log($"{goblin}�� ����");


        //���� �ؽ����̺� ����� ��� ���� Ȯ��
        Debug.Log($"Hashtable Count : {hashT.Count}");

        //�ؽ����̺� �ش� Ű�� ���� ��� ����
        hashT.Remove("Slime");
        Debug.Log($"Hashtable Count : {hashT.Count}");

        //�ؽ����̺� ��� ��� ����
        hashT.Clear();
        Debug.Log($"Hashtable Count : {hashT.Count}");
    }

    public class Goblin { }
    public class Slime { }
}
