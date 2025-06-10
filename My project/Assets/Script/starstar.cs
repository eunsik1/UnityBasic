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
        star = string.Empty;        // ① star 문자열 초기화

        int height = 5;             // ② 찍을 최대 줄 수 (이미지 기준으로 5)
        for (int i = 1; i <= height; i++)   // 1행부터 height행까지
        {
            // ③ 한 줄에 찍을 별(i개) 만들기
            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            // ④ 줄바꿈 추가 (마지막 줄 뒤엔 안 해도 무방)
            if (i < height)
                star += "\n";
        }

        Debug.Log(star);            // ⑤ 완성된 삼각형 문자열을 한 번에 출력
    }


    public void Phase2()
    {
        star = string.Empty;        // ① star 문자열 초기화

        int height = 5;             // ② 찍을 최대 줄 수 (이미지 기준으로 5)
        for(int i = height; i >= 1; i--)   // 1행부터 height행까지
        {
            // ③ 한 줄에 찍을 별(i개) 만들기
            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            // ④ 줄바꿈 추가 (마지막 줄 뒤엔 안 해도 무방)
            if (i > 1)
                star += "\n";
        }

        Debug.Log(star);            // ⑤ 완성된 삼각형 문자열을 한 번에 출력
    }

    public void Phase3()
    {
        star = string.Empty;      // ★ 전체 그림을 담을 변수 초기화

        int height = 5;           // 가장 긴 줄의 별 개수

        // ① 올라가는 부분: 1개 → 5개
        for (int i = 1; i <= height; i++)
        {
            for (int j = 0; j < i; j++)
                star += "★";     // i개 만큼 별 붙이기

            star += "\n";        // 한 줄 끝나면 줄바꿈
        }

        // ② 내려가는 부분: 4개 → 1개
        for (int i = height - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
                star += "★";     // i개 만큼 별 붙이기

            if (i > 1)
                star += "\n";    // 마지막(1개 찍은) 줄 뒤엔 줄바꿈 안 해도 무방
        }

        Debug.Log(star);         // 완성된 패턴을 한 번에 출력
    }


    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5


        Debug.Log(star);
    }
}