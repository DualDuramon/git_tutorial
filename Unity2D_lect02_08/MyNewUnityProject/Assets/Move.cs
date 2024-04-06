using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //����Ż ����Ƽ �Թ� ���� B7
    Vector3 target = new Vector3(6, 0, 0);

    void Update()
    {
        //1. MoveTorward : ��ǥ�������� �ش� �ӵ��� �̵� / �Ű����� : ������ġ, ��ǥ��ġ, �ӵ�
        //transform.position = Vector3.MoveTowards(transform.position, target, 2f);

        //2. SmoothDamp : �ε巯�� ���� �̵� / �Ű����� : ������ġ, ��ǥ��ġ, �����ӵ�, �ӵ���������
        /*
        Vector3 velo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1f);
        */

        //3. Lerp : ��������, smoothdamp���� ���ӽð� �� / �Ű����� : ������ġ, ��ǥ��ġ, �ӵ���������
        //transform.position = Vector3.Lerp(transform.position, target, 0.005f);

        //4. Slerp : ���鼱������ , ȣ�� �׸��� �̵���. / �Ű����� : ������ġ, ��ǥ��ġ, �ӵ���������
        transform.position = Vector3.Slerp(transform.position, target, 0.005f);
    }

}
