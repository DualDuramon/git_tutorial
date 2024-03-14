using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    //C#02 변수 강좌 실습

    private void Awake() {

        string stringVal = "초기화";
        int intVal = 33;
        float floatVal = 12.3456f;

        Debug.Log("stringVal : " + stringVal);

        //정수 -> 문자열 변환
        stringVal = intVal.ToString();
        Debug.Log("stringVal : " + stringVal);

        //실수 -> 문자열 변환
        stringVal = floatVal.ToString();
        Debug.Log("stringVal : " + stringVal);

        /*10. 문자열을 숫자로 형 변환 II - TryParse() 이용
        string stringVal = "숫자아닌 무언가";
        int intVal = 10;

        bool isConversion = int.TryParse(stringVal, out intVal);
        if(isConversion == true) {
            Debug.Log("stringVal : " + stringVal);
            Debug.Log("intVal : " + intVal);
        }
        else {
            Debug.Log("형변환 실패 : stringVal에 있는 내용이 숫자가 아님.");
        }

        */
        /*09. 문자열을 숫자로 형 변환 I - Parse() 이용
        int intVal = 10;
        float floatVal = 12.3456f;
        string stringVal = "33";                //문자열(string)에 숫자가 아닌 데이터가 들어있을 때 숫자로 형 변환 시도하면 에러 발생

        Debug.Log("intVal : " + intVal);
        Debug.Log("floatVal : " + floatVal);
        Debug.Log("stringVal : " + stringVal);

        //stringVal = "33.4567";                //실수를 int로 형 변환 시도하면 에러발생함
        intVal = int.Parse(stringVal);
        stringVal = "33.4567";
        floatVal = float.Parse(stringVal);

        Debug.Log("intVal : " + intVal);
        Debug.Log("floatVal : " + floatVal);
        Debug.Log("stringVal : " + stringVal);
        */

        /* 08. 부동 소수점과 정수 사이의 형 변환.
        float floatVal = 0.9f;
        int intVal = (int)floatVal;

        Debug.Log("floatValue : " + floatVal);
        Debug.Log("intValue : " + intVal);

        floatVal = 1.1f;
        intVal = (int)floatVal;

        Debug.Log("floatValue : " + floatVal);
        Debug.Log("doubleValue : " + intVal);
        */

        /*07. 크기가 서로 다른 부동 소수점 사이의 형 변환
        float floatVal = 69.6875f;
        double doubleVal = (double)floatVal;

        Debug.Log("floatValue : " + floatVal);
        Debug.Log("doubleValue : " + doubleVal);

        floatVal = 0.1f;
        doubleVal = (double)floatVal;

        Debug.Log("floatValue : " + floatVal);
        Debug.Log("doubleValue : " + doubleVal);
        */

        /*06. 부호있는 정수와 부호 없는 정수 사이의 형 변환
        sbyte sbyteVal = 31;
        byte byteVal = (byte)sbyteVal;
        Debug.Log("sbyteValue : " + sbyteVal);
        Debug.Log("byteValue : " + byteVal);

        //Type02. 부호 있는 정수가 음수일 때
        sbyteVal = -31;
        byteVal = (byte)sbyteVal;

        Debug.Log("sbyteValue : " + sbyteVal);
        Debug.Log("byteValue : " + byteVal);

        //Type04. 부호없는 정수가 부호 있는 정수 최대 값보다 클 때
        byteVal = 200;
        sbyteVal = (sbyte)byteVal;

        Debug.Log("sbyteValue : " + sbyteVal);
        Debug.Log("byteValue : " + byteVal);
        */

        /* 05. 크기가 서루 다른 정수(int-sbyte) 사이의 형 변환
        sbyte sbyteValue = 10;
        int intValue = (int)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);

        intValue = 130;
        sbyteValue = (sbyte)intValue;                   //오버플로우 발생. sbyte는 -128 ~ 127까지 저장가능

        Debug.Log("sbuteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);
        */

        /*04. 오브젝트 변수
        object valueInt = 32;                           //모두 박싱(boxing)함.
        object valueFloat = 3.1415926358979f;
        object valueString = "객체지향 프로그래밍!";
        object valueBool = false;

        Debug.Log("정수 오브젝트 : " + valueInt);         //모두 언박싱 과정을 거쳐 그 값을 불러옴.
        Debug.Log("실수 오브젝트 : " + valueFloat);
        Debug.Log("문자열 오브젝트: " + valueString);
        Debug.Log("논리 오브젝트 " + valueBool);
        */

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
