using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //����Ż ����Ƽ �Թ� ���� B5
    
    void Awake() {  //���� ������Ʈ ������ ��, ���� 1�� ����
        Debug.Log("�÷��̾��� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    void OnEnable() {   //���� ������Ʈ�� Ȱ��ȭ �Ǿ����� �����
        Debug.Log("�÷��̾ �α��� �߽��ϴ�.");
    }

    void Start() {  //������Ʈ ���� ����, ���� ����
        Debug.Log("��� ��� ì����ϴ�.");
    }

    void FixedUpdate() {    //���������� �ϱ� ���� ����, 1�ʿ� 50�������� ������ �ֱ�� ȣ��� 
        Debug.Log("�̵��ϴ� ��");
    }

    void Update() {
        //���� ������ ������ ������, �ֱ������� ���ϴ� �׷� ������ ������ ����ϴ� �Լ�
        //�����ֱⰡ ���� ȯ�濡 ���� �ٸ�. ���� �ʴ� 60�� ȣ��
        Debug.Log("���� ���");
    }

    void LateUpdate() { //��� ������Ʈ �Լ��� ������ �����
        Debug.Log("����ġ ȹ��");
    }

    void OnDisable() {  //������Ʈ�� ��Ȱ��ȭ �� �� ����
        Debug.Log("�÷��̾ �α׾ƿ� �߽��ϴ�.");
    }

    void OnDestroy() { //������Ʈ�� �����Ǳ� ������ ���𰡸� ����� �����ȴٴ� �ǹ�
        Debug.Log("�÷��̾� �����͸� �����߽��ϴ�.");
    }

}
