using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //制限時間の指定
    public static float limitTime = 120.0f;
    //残り時間の指定
    public static float countdown;
    //テキストの指定
    public TextMeshProUGUI timer;
    //終了済みの真偽を判定
    private bool timeup;
    //終了後の時間を計測
    private float timeupTime;
    //終了後のメッセージを指定
    public GameObject endMessage;
    //ポーズメニューのプレハブを定義
    public GameObject pauseMenuPrefab;
    //サウンドを管理するオブジェクトの指定
    private GameObject soundManager;
    //開始のメッセージを指定
    public GameObject startMessage;
    //開始サウンドの指定
    public AudioSource startSound;

    // Start is called before the first frame update
    void Start()
    {
        //初期値の設定
        countdown = limitTime;
        timeup = false;
        timeupTime = 2.0f;
        
        timer.text = "";

        //終了後のメッセージを非表示
        endMessage.SetActive(false);

        //サウンドを管理するオブジェクトの探索
        soundManager = GameObject.Find("SoundEffects");
        //開始のサウンドの再生
        soundManager.GetComponent<SoundManager>().StartSound();
        //開始のメッセージの表示
        startMessage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //ゲーム中のカウントダウン
        if(countdown >= 0)
        {
            //ポーズメニューの存在の可否でオブジェクトの流れを制御
            GameObject pauseMenu = GameObject.Find(pauseMenuPrefab.name);
            if (pauseMenu == null)
            {
                //時間の管理
                countdown -= Time.deltaTime;
                //時間の表示
                timer.text = "残り時間：" + countdown.ToString("f1");
            }

            //開始のメッセージの非表示
            if(!startSound.isPlaying)
            {
                startMessage.SetActive(false);
            }
        }
        //時間切れ後の処理
        else
        {
            //時間の表示
            timer.text = "タイムアップ";
            if(timeup == false)
            {
                //終了を案内
                endMessage.SetActive(true);
                //終了判定を真にする
                timeup = true;
                //サウンドの再生
                soundManager.GetComponent<SoundManager>().EndSound();
            }
            //一定時間後、リザルト画面にシーン遷移
            else
            {
                timeupTime -= Time.deltaTime;

                if(timeupTime <= 0)
                {
                    SceneManager.LoadScene("ResultScene");
                }
            }
        }
    }

    //残り時間を提供
    public static float GetTime()
    {
        return countdown;
    }
    //制限時間を提供
    public static float GetLimitTime()
    {
        return limitTime;
    }
}
