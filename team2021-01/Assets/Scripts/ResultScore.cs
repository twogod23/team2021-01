using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultScore : MonoBehaviour
{
    //スコアを表示するオブジェクトを指定
    public TextMeshProUGUI scoretext;
    //得点の指定
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //得点の取得
        score = Score.GetScore();
        //得点を表示
        scoretext.text = string.Format("SCORE : {0}", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
