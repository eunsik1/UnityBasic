using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Text : MonoBehaviour
{
    private string name = "고은식 ";
    private int age = 26;
    private int height = 177;
    private string dream = "기획자 ";
    private string region = "경기도";
    private string MPTI = ("ENFP");
    private string militaryservice = ("전역");
    private string dog = ("강아지");
    private string sing = ("힙합을");
    private string dreamjob = ("컨텐츠 기획자");

    void Start()
    {
        SelfIntroduction();
    }
       public void SelfIntroduction()
    {
        Debug.Log(" 이름은" + name + "입니다.");
        Debug.Log(" 나이는" + age + "입니다.");
        Debug.Log(" 키는" + height + "입니다.");
        Debug.Log(" 꿈은" + dream + "입니다.");
        Debug.Log("사는 곳은" + region + "입니다");
        Debug.Log(" MBTI는" + MPTI + "입니다.");
        Debug.Log("군필여부" + militaryservice + "했습니다");
        Debug.Log("좋아하는 강아지는" + dog + "입니다");
        Debug.Log("노래는" + sing + "좋아합니다");
        Debug.Log("희망직군은" + dreamjob + "입니다");



    }


}