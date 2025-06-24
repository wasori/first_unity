using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonoBehaviour : ����Ƽ ���� ������Ʈ Ŭ����
public class NewBehaviourScript : MonoBehaviour
{
    // �������� ( ������� )
    int health = 30;
    void Start()
    {
        Debug.Log("Hello Unity!");

        ////  1. ���� ////
 
        int level = 5;
        float strength = 15.5f;
        string playerName = "���˻�";
        bool isFullLevel = false;

        //Debug.Log("����� �̸���?");
        //Debug.Log(playerName);
        //Debug.Log("����� ������?");
        //Debug.Log(level);
        //Debug.Log("����� ����?");
        //Debug.Log(strength);
        //Debug.Log("���� �����ΰ�?");
        //Debug.Log(isFullLevel);

        //// 2. �׷��� ���� ////

        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        //Debug.Log("�ʿ� �����ϴ� ����");
        //Debug.Log(monsters[0]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);
        //Debug.Log(monsterLevel[0]);
        //Debug.Log(monsterLevel[1]);
        //Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("������ 30");
        items.Add("�������� 30");

        items.RemoveAt(0);

        //Debug.Log(items[0]);
        //Debug.Log(items[1]);

        //// 3. ������ ////

        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("����� �� ����ġ��?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextExp);

        string title = "������";
        Debug.Log("����� �̸���?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("���� �����Դϱ�? " + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�? " + isEndTutorial);

        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;
        

        string condition = isBadCondition ? "����" : "����";
        Debug.Log("����� ���°� ���޴ϱ�? " + condition);

        //// 4. Ű���� ////

        //// 5. ���ǹ� ////

        //// 6. �ݺ��� ////

        Heal();

        // 8. Ŭ����

        // �ν��Ͻ� : Ŭ������ ������ ����
        Actor player = new Actor();
        player.id = 0;
    }

    //// 7. �Լ� ( �޼ҵ� ) ////
    
    void Heal()
    {
        health += 10;
        Debug.Log("���� �޾ҽ��ϴ�. " + health);
    }
}
