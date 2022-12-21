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
    //直近で獲得したアイテムを判定
    private static string getRecentItem;
    //お手つきの判定をするゲームオブジェクト
    public GameObject otetsukiManager;

    //そうめんの得点計算
    public void GetSomen()
    {
        score += 1;
        getRecentItem = "Somen";
        otetsukiManager.GetComponent<OtetsukiCounter>().GetItem();
    }
    //赤いそうめん
    public void GetRedSomen()
    {
        score += 2;
        getRecentItem = "RedSomen";
        otetsukiManager.GetComponent<OtetsukiCounter>().GetItem();
    }
    //すいか
    public void GetWM()
    {
        score += 3;
        getRecentItem = "WaterMelon";
        otetsukiManager.GetComponent<OtetsukiCounter>().GetItem();
    }

    // Start is called before the first frame update
    void Start()
    {
        //初期値を設定
        score = 0;
        scoretxt.text = "";
        getRecentItem = "";
    }

    // Update is called once per frame
    void Update()
    {
        //得点の表示
        scoretxt.text = "得点：" + score.ToString();
    }

    //他のスクリプトで得点を取得
    public static int GetScore()
    {
        return score;
    }

    //他のスクリプトでそうめんの獲得有無を取得
    public static string GetInSomen()
    {
        return getRecentItem;
    }
}
