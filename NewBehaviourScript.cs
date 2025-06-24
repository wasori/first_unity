using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonoBehaviour : 유니티 게임 오브젝트 클래스
public class NewBehaviourScript : MonoBehaviour
{
    // 전역변수 ( 멤버변수 )
    int health = 30;
    void Start()
    {
        Debug.Log("Hello Unity!");

        ////  1. 변수 ////
 
        int level = 5;
        float strength = 15.5f;
        string playerName = "나검사";
        bool isFullLevel = false;

        //Debug.Log("용사의 이름은?");
        //Debug.Log(playerName);
        //Debug.Log("용사의 레벨은?");
        //Debug.Log(level);
        //Debug.Log("용사의 힘은?");
        //Debug.Log(strength);
        //Debug.Log("용사는 만렙인가?");
        //Debug.Log(isFullLevel);

        //// 2. 그룹형 변수 ////

        string[] monsters = { "슬라임", "사막벰", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        //Debug.Log("맵에 존재하는 몬스터");
        //Debug.Log(monsters[0]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);
        //Debug.Log(monsterLevel[0]);
        //Debug.Log(monsterLevel[1]);
        //Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약 30");
        items.Add("마나물약 30");

        items.RemoveAt(0);

        //Debug.Log(items[0]);
        //Debug.Log(items[1]);

        //// 3. 연산자 ////

        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까? " + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;
        

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까? " + condition);

        //// 4. 키워드 ////

        //// 5. 조건문 ////

        //// 6. 반복문 ////

        Heal();

        // 8. 클래스

        // 인스턴스 : 클래스를 변수로 만듬
        Actor player = new Actor();
        player.id = 0;
    }

    //// 7. 함수 ( 메소드 ) ////
    
    void Heal()
    {
        health += 10;
        Debug.Log("힐을 받았습니다. " + health);
    }
}
