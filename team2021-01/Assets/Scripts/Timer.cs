using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    //制限時間の指定
    public static float countdown = 120.0f;
    //テキストの指定
    public TextMeshProUGUI timer;

    // Start is called before the first frame update
    void Start()
    {
        timer.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown >= 0)
        {
            //時間の管理
            countdown -= Time.deltaTime;
            //時間の表示
            timer.text = "残り時間：" + countdown.ToString("f2");
        }
        else
        {
            timer.text = "タイムアップ";
        }
    }

    public static float GetTime()
    {
        return countdown;
    }
}
