using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEntity{
    //C#강좌 14 - 프로퍼티

    //추상 클래스 프로퍼티
    abstract public int Shield {    //추상 프로퍼티
        get;set;
    }
    public int Defense {
        get;set;
    }
}
