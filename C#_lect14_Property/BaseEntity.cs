using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEntity{
    //C#���� 14 - ������Ƽ

    //�߻� Ŭ���� ������Ƽ
    abstract public int Shield {    //�߻� ������Ƽ
        get;set;
    }
    public int Defense {
        get;set;
    }
}
