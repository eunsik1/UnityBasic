using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    int count;

    void Awake()
    {
        count = 0;
    }
    private void Start()
    {
        for(int i = 0; i <5; i++)
        {
            Debug.Log("반복문이 실행됬어요."); 
        }
        // i = 0 , 0 < 5
        Debug.Log("반복문이 실행됬어요.");
        // i = 0 , 1 < 5
        Debug.Log("반복문이 실행됬어요.");
        // i = 0 , 2 < 5
        Debug.Log("반복문이 실행됬어요.");
        // i = 0 , 3 < 5
        Debug.Log("반복문이 실행됬어요.");
        // i = 0 , 4 < 5
        Debug.Log("반복문이 실행됬어요.");
        
    }
    public void Gacha()

    {
        
        for(int i = 0;  i< 10; i++)
        {
            int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

            Debug.Log($"랜덤한 값은 : {randomValue} 입니다");
            // count 81
            if (8 <= count)
            {
                Debug.Log("확정으로 '각청'을 뽑았다!");
                count = 0;
            }
            else if (randomValue <= 10) // 1 ~ 10 -> 10%
            {
                Debug.Log("'각청'을 뽑았다!");
            }
            else if (randomValue <= 30) // 11 ~ 30
            {
                Debug.Log("'모나'을 뽑았다!");
            }
            else
            {
                Debug.Log("'치치'를 뽑아버렸다!");
            }

            count++;

        }
       
    }


    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe)
        {
            case 0:
                // 은색 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'은색 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;
        }
    }
}

