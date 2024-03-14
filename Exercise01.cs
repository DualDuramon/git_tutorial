using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    //C#02 변수 강좌 실습


    private void Awake() {

        object valueInt = 32;                           //모두 박싱(boxing)함.
        object valueFloat = 3.1415926358979f;
        object valueString = "객체지향 프로그래밍!";
        object valueBool = false;

        Debug.Log("정수 오브젝트 : " + valueInt);         //모두 언박싱 과정을 거쳐 그 값을 불러옴.
        Debug.Log("실수 오브젝트 : " + valueFloat);
        Debug.Log("문자열 오브젝트: " + valueString);
        Debug.Log("논리 오브젝트 " + valueBool);


        /* 03. 문자열, 논리
        string stringVal = "Hello World!";
        bool boolVal = true;

        Debug.Log("string Data : " + stringVal);
        Debug.Log("bool Data : " + boolVal);
        */

        /* 02. 실수
        float floatValue01 = 3.1412348965443215462187562154321532156480f;   //7자리 표현
        float floatValue02 = 31.412348965443215462187562154321532156480f;   //7자리 표현
        double doubleValue = 3.1412348965443215462187562154321532156480;    //16자리 표현
        decimal decimalValue = 3.1412348965443215462187562154321532156480m; //29자리 표현

        Debug.Log("float Data : " + floatValue01);
        Debug.Log("float Data : " + floatValue02);

        Debug.Log("double Data : " + doubleValue);
        Debug.Log("decimal Data : " + decimalValue);
        */

        /* 01. 정수
        sbyte byteValue = -128;                     //1바이트 : -128 ~ 127
        byte ubyteValue = 255;                      //1바이트 unsigned Byte : 0 ~ 255
        short shortValue = -32768;                  //2바이트 : -32,768 ~ 32,767
        ushort ushortValue = 65535;                 //2바이트 unsigned short : 0~65,535;
        int intValue = -1247483648;                 //4바이트 : -2,147,483,648 ~ 2,147,483,647
        uint uintValue = 4294967295;                //4바이트 unsigned int : 0 ~ 4,294,967,295
        long longValue = -922337203685477508;       //8바이트 : -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
        ulong ulongValue = 18446744073709551615;    //8바이트 unsinged long :  0 ~ 18,446,744,073,709,551,615
        char charValue = 'K';                       //2바이트

        Debug.Log("byte Data : " + byteValue);
        Debug.Log("sbyte Data : " + ubyteValue);

        Debug.Log("short Data : " + shortValue);
        Debug.Log("ushort Data : " + ushortValue);

        Debug.Log("int Data : " + intValue);
        Debug.Log("uint Data : " + uintValue);

        Debug.Log("long Data : " + longValue);
        Debug.Log("ulong Data : " + ulongValue);

        Debug.Log("char Data : " + charValue);
        */
    }
}
