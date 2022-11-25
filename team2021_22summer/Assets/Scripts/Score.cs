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

    //制限時間の管理
    private float time;
    //アイテム獲得時間の管理
    private float getTime;
    //手の画像を指定
    public GameObject handImage;

    //そうめんの得点計算
    public void GetSomen()
    {
        score += 1;
        getRecentItem = "Somen";
        getTime = time;
    }
    //赤いそうめん
    public void GetRedSomen()
    {
        score += 2;
        getRecentItem = "RedSomen";
        getTime = time;
    }
    //すいか
    public void GetWM()
    {
        score += 3;
        getRecentItem = "WaterMelon";
        getTime = time;
    }

    // Start is called before the first frame update
    void Start()
    {
        //時間の取得・初期化
        time = Timer.GetLimitTime();
        getTime = time + 2.0f;
        
        //初期値を設定
        score = 0;
        scoretxt.text = "";
        getRecentItem = "";

        //手の画像を表示
        handImage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //得点の表示
        scoretxt.text = "得点：" + score.ToString();

        //時間の取得
        time = Timer.GetTime();

        //アイテム取得有無によって、手の表示の有無を設定
        if ((getTime - time) < 2.0f)
        {
            handImage.SetActive(false);
        }
        else
        {
            handImage.SetActive(true);
        }
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
