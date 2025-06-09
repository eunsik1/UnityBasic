using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
   
   
    int pityCount;

    void Awake()
    {
        pityCount = 0;
    }

    public void Gacha()
    {
        // 10���� �̱� ���� ����
        List<string> results = GachaTenPullWithList();

        Debug.Log("=== 10���� ��� ===");
        for (int i = 0; i < results.Count; i++)
        {
            Debug.Log($"{i + 1}�� �̱�: {results[i]}");
        }
    }

    /// <summary>
    /// List<string>�� ����Ͽ� 10�� �̱��� ����� ��� ��ȯ
    /// </summary>
    public List<string> GachaTenPullWithList()
    {
        List<string> pullResults = new List<string>();

        for (int i = 0; i < 10; i++)
        {
            string singleResult = GachaGetResult();
            pullResults.Add(singleResult);
        }

        return pullResults;
    }

    /// <summary>
    /// �� �� �̱⸦ �����ϰ� ��� ���ڿ��� ��ȯ
    /// </summary>
    private string GachaGetResult()
    {
        int randomValue = Random.Range(1, 101); // 1~100
        string result;

        // 9ȸ ���� ���� �� 10��°�� Ȯ������ ���� ���
        if (pityCount >= 9)
        {
            result = "Ȯ�� ��û";
            pityCount = 0;
        }
        else if (randomValue <= 10)      // 10%
        {
            result = "��û";
            pityCount = 0;
        }
        else if (randomValue <= 30)      // +20% = 30%
        {
            result = "��";
            pityCount++;
        }
        else                             // ������ 70%
        {
            result = "ġġ";
            pityCount++;
        }

        return result;
    }
}

