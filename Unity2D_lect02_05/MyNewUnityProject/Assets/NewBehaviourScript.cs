using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //����Ż ����Ƽ�Թ����� B4
    
    string title = "������";
    string playerName = "DualDura"; 
    int level = 5;
    float strength = 15.5f;
    int exp = 1500;
    int health = 30;
    int mana = 25;
    bool isFullLevel = false;

    void Start()
    {
        Debug.Log("Hello Unity!");

        //1. ����
        //int level = 5;                  //������
        //float strength = 15.5f;         //�Ǽ���
        //string playerName = "DualDura"; //������
        //bool isFullLevel = false;       //����
        /*
        Debug.Log("����� �̸���?");
        Debug.Log(playerName);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(isFullLevel);
        */
        
        //2. �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };

        /*
        Debug.Log("�ʿ� �����ϴ� ����");
        Debug.Log(monsters[0]); 
        Debug.Log(monsters[1]); 
        Debug.Log(monsters[2]);
        */

        int[] monstersLevel = new int[3];
        monstersLevel[0] = 1;
        monstersLevel[1] = 6;
        monstersLevel[2] = 20;


        /*
        Debug.Log("�ʿ� �����ϴ� ���� ����");
        Debug.Log(monstersLevel[0]);
        Debug.Log(monstersLevel[1]);
        Debug.Log(monstersLevel[2]);
        */

        List<string> items = new List<string>();    //���׸���
        items.Add("������30");
        items.Add("��������30");

        /*
        Debug.Log("������ �ִ� ������");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(0);

        Debug.Log("������ �ִ� ������");
        Debug.Log(items[0]);                //��Ұ� ���� �ε��� ����->����
        Debug.Log(items[1]);   
        */

        //3. ������
        //int exp = 1500;

        exp = 1500 + 320;               //��Ģ����
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("����� �� ����ġ?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);    //������ ���
        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextExp);

        //string title = "������";
        Debug.Log("����� �̸���?");
        Debug.Log(title + " "+playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;  //�񱳿�����
        Debug.Log("���� �����Դϱ�? " + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�? " + isEndTutorial);

        //int health = 30;
        //int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;       //end ������
        bool isBadCondition = health <= 50 || mana <= 20;         //or ������
        //Debug.Log("����� ���°� ���޴ϱ�? " + isBadCondition);

        string condition = isBadCondition ? "����" : "����";        //���׿�����
        Debug.Log("����� ���°� ���޴ϱ�? " + condition);

        //4. Ű���� : ���α׷��� �� �����ϴ� Ư���� �ܾ�. ���� �̸����� ����� �� ����.
        //int flaot = 0; string bool = false;

        //5. ���ǹ�
        if (condition == "����") {
            Debug.Log("�÷��̾��� ���°� ���ڴ� �������� ����ϼ���");
        }
        else {
            Debug.Log("�÷��̾��� ���°� �����ϴ�");
        }

        if (isBadCondition && items[0] == "������30") {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("��������30�� ����߽��ϴ�");
        }
        else if(isBadCondition && items[0] == "��������30") {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("��������30�� ����߽��ϴ�");
        }

        string monsterAlarm;
        switch (monsters[0]) {
            case "������": case "�縷��":
                monsterAlarm = "���� ���� ����!";
                break;
            case "�Ǹ�":
                monsterAlarm = "���� ���� ����!";
                break;
            case "��":
                monsterAlarm = "���� ���� ����!";
                break;
            default:
                monsterAlarm = "??? ���� ����!";
                break;
        }
        Debug.Log(monsterAlarm);

        //6. �ݸ��
        while(health > 0) {
            health--;

            if (health > 0)
                Debug.Log("�� �������� �Ծ����ϴ� " + health);
            else
                Debug.Log("����߽��ϴ�.");

            if (health == 10) {
                Debug.Log("�ص����� ����մϴ�");
                break;
            }
        }

        for (int count = 0; count < 10; count++) {
            health++;
            //Debug.Log("�ش밨����... " + health);
        }

        for (int idx = 0; idx < monsters.Length; idx++) {
            //Debug.Log("�� ������ �ִ� ���� : " + monsters[idx]);
        }

        foreach (string monster in monsters) {
            Debug.Log("�� ������ �ִ� ���� : " + monster);
        }

        //7. �Լ�(�޼���)
        //health = Heal(health);
        
        Heal();
        for (int idx = 0; idx < monsters.Length; idx++) {
            Debug.Log("���� " + monsters[idx] + "���� " + Battle(monstersLevel[idx]));
        }

        //8. Ŭ����
        Player player = new Player();         //�ν��Ͻ�ȭ
        player.id = 0;
        player.name = "�����";
        player.title = "������";
        player.strength = 2.4f;
        player.weapon = "���� ������";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������ " + player.level + "�Դϴ�.");
        Debug.Log(player.move());

    }// end of start()

    //7.�Լ�(�޼���)
    int Heal(int currentHealth) {
        currentHealth += 10;
        Debug.Log("���� �޾ҽ��ϴ�. " + currentHealth);
        return currentHealth;
    }

    void Heal() {
        health += 10;
        Debug.Log("���� �޾ҽ��ϴ�. " + health);

    }

    string Battle(int monsterLevel) {
        string result;
        if (level >= monsterLevel) {
            result = "�̰���ϴ�.";
        }
        else {
            result = "�й��߽��ϴ�.";
        }

        return result;
    }

}
