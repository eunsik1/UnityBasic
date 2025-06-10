using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starstar : MonoBehaviour
{
    // Start is called before the first frame update
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;        // �� star ���ڿ� �ʱ�ȭ

        int height = 5;             // �� ���� �ִ� �� �� (�̹��� �������� 5)
        for (int i = 1; i <= height; i++)   // 1����� height�����
        {
            // �� �� �ٿ� ���� ��(i��) �����
            for (int j = 0; j < i; j++)
            {
                star += "��";
            }
            // �� �ٹٲ� �߰� (������ �� �ڿ� �� �ص� ����)
            if (i < height)
                star += "\n";
        }

        Debug.Log(star);            // �� �ϼ��� �ﰢ�� ���ڿ��� �� ���� ���
    }


    public void Phase2()
    {
        star = string.Empty;        // �� star ���ڿ� �ʱ�ȭ

        int height = 5;             // �� ���� �ִ� �� �� (�̹��� �������� 5)
        for(int i = height; i >= 1; i--)   // 1����� height�����
        {
            // �� �� �ٿ� ���� ��(i��) �����
            for (int j = 0; j < i; j++)
            {
                star += "��";
            }
            // �� �ٹٲ� �߰� (������ �� �ڿ� �� �ص� ����)
            if (i > 1)
                star += "\n";
        }

        Debug.Log(star);            // �� �ϼ��� �ﰢ�� ���ڿ��� �� ���� ���
    }

    public void Phase3()
    {
        star = string.Empty;      // �� ��ü �׸��� ���� ���� �ʱ�ȭ

        int height = 5;           // ���� �� ���� �� ����

        // �� �ö󰡴� �κ�: 1�� �� 5��
        for (int i = 1; i <= height; i++)
        {
            for (int j = 0; j < i; j++)
                star += "��";     // i�� ��ŭ �� ���̱�

            star += "\n";        // �� �� ������ �ٹٲ�
        }

        // �� �������� �κ�: 4�� �� 1��
        for (int i = height - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
                star += "��";     // i�� ��ŭ �� ���̱�

            if (i > 1)
                star += "\n";    // ������(1�� ����) �� �ڿ� �ٹٲ� �� �ص� ����
        }

        Debug.Log(star);         // �ϼ��� ������ �� ���� ���
    }


    public void Phase4()
    {
        star = string.Empty;

        // ������ 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5


        Debug.Log(star);
    }
}