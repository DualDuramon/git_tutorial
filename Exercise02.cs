using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise02 : MonoBehaviour
{
    private void Awake() {

        string position = "3,5,6";

        string[] str = position.Split(',');             //쉼표를 기준으로 해당 문자열 분할, 배열로 반환
        Debug.Log($"{str[0]} {str[1]} {str[2]}");

        string str2 = "HELLO, WORLD";
        str2 = str2.Substring(7);       //7번 인덱스 다음부터 시작하는 문자열 추출
        Debug.Log(str2);
        /*
        string str = "HELLO, WORLD";
        Debug.Log(str);

        str = str.ToLower();                //문자열을 모두 소문자로 바꾸기
        Debug.Log($"ToLower() : {str}");

        str = str.ToUpper();                //문자열을 모두 대문자로 바꾸기
        Debug.Log($"ToUpper() : {str}");

        str = str.Insert(0, "Hi~ ");        //0번 위치에 문자열 삽입
        Debug.Log($"Insert() : {str}");

        str = str.Remove(0, 4);             //0번~4번의 문자 제거
        Debug.Log($"Remove() : {str}");
        
        Debug.Log("=======Trim===========");

        str = "      " + str + "      ";    //공백 추가
        Debug.Log(str + "공백체크");

        str = str.Trim();                   //앞뒤 공백 제거
        //str = str.TrimStart();              //앞쪽 공백 제거
        //str = str.TrimEnd();                //뒷쪽 공백 제거
        Debug.Log(str + "공백체크");

        Debug.Log($"Before Replace : {str}");
        str = str.Replace("HELLO", "BYE");      //문자열 대체
        Debug.Log($"After Replace : {str}");
        */
        

        /*03.문자열 탐색
        string str = "Hello, World";
        Debug.Log(str);

        int numeric = str.IndexOf('o');     //o 찾기
        Debug.Log($"o는 앞에서부터{numeric + 1}번째에 있습니다.");

        numeric = str.LastIndexOf('o');
        Debug.Log($"o는 뒤에서부터{numeric + 1}번째에 있습니다.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str} 문장은 Hello부터 시작하는가? : {isTrue}");

        isTrue = str.StartsWith("World");
        Debug.Log($"{str}문장은 World부터 시작하는가? : {isTrue}");

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str} 문장은 Hello로 끝나는가? : {isTrue}");

        isTrue = str.EndsWith("World");
        Debug.Log($"{str} 문장은 World로 끝나는가? : {isTrue}");

        isTrue = str.Contains("Hell");
        Debug.Log($"{str}문장에 Hell이 포함되어 있는가? : {isTrue}");
        */

        /* 02. string.Format() vs 문자열 보간
        int minutes = 1;
        int seconds = 15;

        //string.Format() 이용
        Debug.Log(string.Format("{0}{1}{2}", minutes, " : ", seconds));
        //문자열 보간 사용
        Debug.Log($"{minutes} : {seconds}");

        //string.Format() 사용
        Debug.Log(string.Format("{0,-10:D5}", minutes));
        //문자열 보간 사용
        Debug.Log($"{minutes,-10:D5}");
        */

        /*01. string.Format()을 이용한 문자열 가공.
        int minutes = 1;
        int seconds = 15;

        //서식 항목 - 맞춤
        Debug.Log(string.Format("기본 : {0}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("왼쪽 맞춤 : {0,-5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("오른쪽 맞춤 : {0,5}{1}{2}", minutes, ":", seconds));

        //서식 항목 - 서식 문자열 설정(숫자)
        Debug.Log(string.Format("10진수 서식화 : {0:D}", 123));
        Debug.Log(string.Format("10진수 서식화(5자리) : {0:D5}", 123));
        
        Debug.Log(string.Format("16진수 서식화 : {0:X}", 0x00));
        Debug.Log(string.Format("16진수 서식화(10자리) : {0:X10}", 0x00));

        Debug.Log(string.Format("고정 소수점 서식화 : {0:F}", 1.23));
        Debug.Log(string.Format("고정 소수점 서식화 (소수점 1자리) : {0:F1}", 1.23));

        Debug.Log(string.Format("콤마로 구분하기 : {0:N}", 1234567890));
        Debug.Log(string.Format("지수 : {0:E}", 1234567890));

        //서식 문자열 설정(날짜)
        //DateTime 구조체를 사용하려면 using System; 추가
        DateTime dt = new DateTime(2020, 2, 22, 13, 40, 0);
        string str = dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)");
        Debug.Log(str);

        str = dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)");
        Debug.Log(str);
        */

    }
}
