using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//C# ���� 12 - Ŭ���� ��ȭ
//�������̽�
interface ImovingEntity {
    void MoveTo(Vector3 destination);
}

interface IcombatEntity {
    void Attack(Entity entity);
}