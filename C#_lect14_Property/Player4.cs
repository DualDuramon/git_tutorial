using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4 : BaseEntity {
    //C#���� 14 - ������Ƽ

    // �߻� Ŭ���� ������Ƽ ����
    public override int Shield {  //�߻� ������Ƽ ����
        get; set;
    }
    public string ID {
        get; set;
    }

    /* ������ ���� ������Ƽ ȣ��
    public int CurrentHp {
        get; set;
    }
    public string ID {
        get; set;
    }
    */

    /* �б�/�������� ������Ƽ
    private int currentHp;
    public int CurrentHp {  //�б� ���� ������Ƽ
        get => currentHp;
    }

    private int currentMp;
    public int CurrentMp {  //���� ���� ������Ƽ
        set => currentMp = value;
    }

    private string Id;
    public string ID {  //���� ������ ���
        get => Id;
        private set {   //Ŭ���� ���ο����� set ��� ����
            Id = value;
        }
    }
    */
    /* �ڵ����� ������Ƽ
    public int CurrentHp {  //�ڵ����� ������Ƽ. ������ ���� ���� ���ص� ��
        get; set;
    }
    public string Id {
        get; set;
    }
    */

    /* ������Ƽ ����
    private int currentHp;
    public int CurrentHp {
        get => currentHp;   //������ �����̶�� => ���
        set {               //������ �������̸� �߰�ȣ ���
            if (value > 0) {
                currentHp = value;
            }
            else {
                currentHp = 0;
            }
        }
    }
    */
}
