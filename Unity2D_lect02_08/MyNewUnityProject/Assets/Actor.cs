using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor {
    //����Ż ����Ƽ �Թ����� B4

    //8.Ŭ���� 
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk() {
        return "��ȭ�� �ɾ����ϴ�.";
    }
    public string HasWeapon() {
        return weapon;
    }
    public void LevelUp() {
        level = level + 1;
    }
}