using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    //������-�޼ҵ� �������̵�
   public virtual void Attack() {
        Debug.Log("���� �����Ѵ�");
    }

    public void Heal() {
        Debug.Log("ü�� ȸ����");
    }

    //������ - upCasting
    public void TakeDamage(int dmg) {
        Debug.Log($"�� : {dmg}��ŭ ü�� ����");
    }

}

//�������̽� ���
public class Goblin : ImovingEntity {
    public void MoveTo(Vector3 destination) {
        Debug.Log($"{destination} ���� �ɾ �̵���");
    }
}

public class Slime : ImovingEntity {
    public void MoveTo(Vector3 destination) {
        Debug.Log($"{destination} ���� �� �̵���");
    }
}

public class Butterfly : ImovingEntity {
    public void MoveTo(Vector3 destination) {
        Debug.Log($"{destination} ���� ���Ƽ� �̵���");
    }
}

/* ������- �޼ҵ� �������̵� �� ��ĳ����
public class Goblin : Entity {
    public override void Attack() {
        Debug.Log("����� ������ ����!");
    }

    //������-upCasting
    public void TakeDamage(int dmg) {
        Debug.Log($"��� : {dmg}��ŭ ü�� ����");
    }
}

public class Slime : Entity {
    public override void Attack() {
        Debug.Log("�������� �����ġ�� ����!");
    }

    //������-upCasting
    public void TakeDamage(int dmg) {
        Debug.Log($"������ : {dmg}��ŭ ü�� ����");
    }
}

public class Dragon : Entity{
    public override void Attack() {
        Debug.Log("�巡���� ȭ�� �극��!");
    }

    //������-upCasting
    public void TakeDamage(int dmg) {
        Debug.Log($"�巡�� : {dmg}��ŭ ü�� ����");
    }
}*/