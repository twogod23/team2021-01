using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    //得点の指定
    public static int score;
    //テキストの指定
    public TextMeshProUGUI scoretxt;

    //そうめんの得点計算
    public void GetSomen()
    {
        score += 1;
    }
    //赤いそうめん
    public void GetRedSomen()
    {
        score += 2;
    }
    //すいか
    public void GetWM()
    {
        score += 3;
    }

    // Start is called before the first frame update
    void Start()
    {
        //初期値を設定
        score = 0;
        scoretxt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = "得点：" + score.ToString();
    }

    //他のスクリプトで得点を取得
    public static int GetScore()
    {
        return score;
    }
}
