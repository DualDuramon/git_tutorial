using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//C# 강좌 12 - 클래스 심화
//인터페이스
interface ImovingEntity {
    void MoveTo(Vector3 destination);
}

interface IcombatEntity {
    void Attack(Entity entity);
}