using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IBaseEntity {
    //C#강좌 14 - 프로퍼티
    string ID { get; set; }     //인터페이스 프로퍼티
    int Damage { get; set; }    //컴파일러가 구현 안해줌
    int currentHP { get; set; } //자식클래스에서 재정의 필요
}
