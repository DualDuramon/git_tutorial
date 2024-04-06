using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    //����Ż ����Ƽ �Թ� ���� B10 ~ 12
    
    Rigidbody rigid;    //RigidBody ������Ʈ

    void Start() {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        /*
        //rigid.velocity = new Vector3(2, 4, -1); // #1.�ӷ¹ٲٱ�

        //#2.�� ���ϱ�
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

        //#3.ȸ����
        //rigid.AddTorque(Vector3.up); //���޹��� vec�� ������ ȸ���� ����
        */
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);


    }

    void OnTriggerStay(Collider other) {
        if (other.name == "Pillar") {
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
    }

    public void Jump() {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }

}
