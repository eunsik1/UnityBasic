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
        // 10연차 뽑기 실행 예시
        List<string> results = GachaTenPullWithList();

        Debug.Log("=== 10연차 결과 ===");
        for (int i = 0; i < results.Count; i++)
        {
            Debug.Log($"{i + 1}번 뽑기: {results[i]}");
        }
    }

    /// <summary>
    /// List<string>을 사용하여 10번 뽑기의 결과를 모아 반환
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
    /// 한 번 뽑기를 수행하고 결과 문자열을 반환
    /// </summary>
    private string GachaGetResult()
    {
        int randomValue = Random.Range(1, 101); // 1~100
        string result;

        // 9회 연속 실패 시 10번째는 확정으로 상위 등급
        if (pityCount >= 9)
        {
            result = "확정 각청";
            pityCount = 0;
        }
        else if (randomValue <= 10)      // 10%
        {
            result = "각청";
            pityCount = 0;
        }
        else if (randomValue <= 30)      // +20% = 30%
        {
            result = "모나";
            pityCount++;
        }
        else                             // 나머지 70%
        {
            result = "치치";
            pityCount++;
        }

        return result;
    }
}

