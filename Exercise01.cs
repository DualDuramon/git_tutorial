using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    //C#02 ���� ���� �ǽ�


    private void Awake() {

        object valueInt = 32;                           //��� �ڽ�(boxing)��.
        object valueFloat = 3.1415926358979f;
        object valueString = "��ü���� ���α׷���!";
        object valueBool = false;

        Debug.Log("���� ������Ʈ : " + valueInt);         //��� ��ڽ� ������ ���� �� ���� �ҷ���.
        Debug.Log("�Ǽ� ������Ʈ : " + valueFloat);
        Debug.Log("���ڿ� ������Ʈ: " + valueString);
        Debug.Log("�� ������Ʈ " + valueBool);


        /* 03. ���ڿ�, ��
        string stringVal = "Hello World!";
        bool boolVal = true;

        Debug.Log("string Data : " + stringVal);
        Debug.Log("bool Data : " + boolVal);
        */

        /* 02. �Ǽ�
        float floatValue01 = 3.1412348965443215462187562154321532156480f;   //7�ڸ� ǥ��
        float floatValue02 = 31.412348965443215462187562154321532156480f;   //7�ڸ� ǥ��
        double doubleValue = 3.1412348965443215462187562154321532156480;    //16�ڸ� ǥ��
        decimal decimalValue = 3.1412348965443215462187562154321532156480m; //29�ڸ� ǥ��

        Debug.Log("float Data : " + floatValue01);
        Debug.Log("float Data : " + floatValue02);

        Debug.Log("double Data : " + doubleValue);
        Debug.Log("decimal Data : " + decimalValue);
        */

        /* 01. ����
        sbyte byteValue = -128;                     //1����Ʈ : -128 ~ 127
        byte ubyteValue = 255;                      //1����Ʈ unsigned Byte : 0 ~ 255
        short shortValue = -32768;                  //2����Ʈ : -32,768 ~ 32,767
        ushort ushortValue = 65535;                 //2����Ʈ unsigned short : 0~65,535;
        int intValue = -1247483648;                 //4����Ʈ : -2,147,483,648 ~ 2,147,483,647
        uint uintValue = 4294967295;                //4����Ʈ unsigned int : 0 ~ 4,294,967,295
        long longValue = -922337203685477508;       //8����Ʈ : -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
        ulong ulongValue = 18446744073709551615;    //8����Ʈ unsinged long :  0 ~ 18,446,744,073,709,551,615
        char charValue = 'K';                       //2����Ʈ

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
