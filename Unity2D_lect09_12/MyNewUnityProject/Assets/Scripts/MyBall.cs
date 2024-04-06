using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    //골드메탈 유니티 입문 강좌 B10 ~ 12
    
    Rigidbody rigid;    //RigidBody 컴포넌트

    void Start() {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        /*
        //rigid.velocity = new Vector3(2, 4, -1); // #1.속력바꾸기

        //#2.힘 가하기
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

        //#3.회전력
        //rigid.AddTorque(Vector3.up); //전달받은 vec를 축으로 회전이 생김
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
