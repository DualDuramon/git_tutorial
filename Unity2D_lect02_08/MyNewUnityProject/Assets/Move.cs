using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //골드메탈 유니티 입문 강좌 B7
    Vector3 target = new Vector3(6, 0, 0);

    void Update()
    {
        //1. MoveTorward : 목표지점으로 해당 속도로 이동 / 매개변수 : 현재위치, 목표위치, 속도
        //transform.position = Vector3.MoveTowards(transform.position, target, 2f);

        //2. SmoothDamp : 부드러운 감속 이동 / 매개변수 : 현재위치, 목표위치, 참조속도, 속도감속정도
        /*
        Vector3 velo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1f);
        */

        //3. Lerp : 선형보간, smoothdamp보다 감속시간 김 / 매개변수 : 현재위치, 목표위치, 속도감속정도
        //transform.position = Vector3.Lerp(transform.position, target, 0.005f);

        //4. Slerp : 구면선형보간 , 호를 그리며 이동함. / 매개변수 : 현재위치, 목표위치, 속도감속정도
        transform.position = Vector3.Slerp(transform.position, target, 0.005f);
    }

}
