using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Text : MonoBehaviour
{
    private string name = "������ ";
    private int age = 26;
    private int height = 177;
    private string dream = "��ȹ�� ";
    private string region = "��⵵";
    private string MPTI = ("ENFP");
    private string militaryservice = ("����");
    private string dog = ("������");
    private string sing = ("������");
    private string dreamjob = ("������ ��ȹ��");

    void Start()
    {
        SelfIntroduction();
    }
       public void SelfIntroduction()
    {
        Debug.Log(" �̸���" + name + "�Դϴ�.");
        Debug.Log(" ���̴�" + age + "�Դϴ�.");
        Debug.Log(" Ű��" + height + "�Դϴ�.");
        Debug.Log(" ����" + dream + "�Դϴ�.");
        Debug.Log("��� ����" + region + "�Դϴ�");
        Debug.Log(" MBTI��" + MPTI + "�Դϴ�.");
        Debug.Log("���ʿ���" + militaryservice + "�߽��ϴ�");
        Debug.Log("�����ϴ� ��������" + dog + "�Դϴ�");
        Debug.Log("�뷡��" + sing + "�����մϴ�");
        Debug.Log("���������" + dreamjob + "�Դϴ�");



    }


}