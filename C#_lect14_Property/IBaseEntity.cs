using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IBaseEntity {
    //C#���� 14 - ������Ƽ
    string ID { get; set; }     //�������̽� ������Ƽ
    int Damage { get; set; }    //�����Ϸ��� ���� ������
    int currentHP { get; set; } //�ڽ�Ŭ�������� ������ �ʿ�
}
