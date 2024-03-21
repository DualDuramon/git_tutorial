using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    //다형성-메소드 오버라이딩
   public virtual void Attack() {
        Debug.Log("적을 공격한다");
    }

    public void Heal() {
        Debug.Log("체력 회복중");
    }

    //다형성 - upCasting
    public void TakeDamage(int dmg) {
        Debug.Log($"적 : {dmg}만큼 체력 감소");
    }

}

//인터페이스 상속
public class Goblin : ImovingEntity {
    public void MoveTo(Vector3 destination) {
        Debug.Log($"{destination} 까지 걸어서 이동중");
    }
}

public class Slime : ImovingEntity {
    public void MoveTo(Vector3 destination) {
        Debug.Log($"{destination} 까지 기어서 이동중");
    }
}

public class Butterfly : ImovingEntity {
    public void MoveTo(Vector3 destination) {
        Debug.Log($"{destination} 까지 날아서 이동중");
    }
}

/* 다형성- 메소드 오버라이딩 및 업캐스팅
public class Goblin : Entity {
    public override void Attack() {
        Debug.Log("고블린의 몽둥이 공격!");
    }

    //다형성-upCasting
    public void TakeDamage(int dmg) {
        Debug.Log($"고블린 : {dmg}만큼 체력 감소");
    }
}

public class Slime : Entity {
    public override void Attack() {
        Debug.Log("슬라임의 몸통박치기 공격!");
    }

    //다형성-upCasting
    public void TakeDamage(int dmg) {
        Debug.Log($"슬라임 : {dmg}만큼 체력 감소");
    }
}

public class Dragon : Entity{
    public override void Attack() {
        Debug.Log("드래곤의 화염 브레스!");
    }

    //다형성-upCasting
    public void TakeDamage(int dmg) {
        Debug.Log($"드래곤 : {dmg}만큼 체력 감소");
    }
}*/