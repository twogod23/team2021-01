using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePauseMenu : MonoBehaviour
{
    //ポーズメニュー画面の指定
    public GameObject pauseMenu;
    //ポーズメニュー画面へ遷移するボタンの指定
    public GameObject pauseButton;
    //お手つきの判定をするゲームオブジェクト
    public GameObject otetsukiManager;
    //サウンドを管理するオブジェクトの指定
    private GameObject soundManager;

    void Start()
    {
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        soundManager = GameObject.Find("SoundEffects");
    }
    
    //ポーズメニューを無効にする
    public void close()
    {
        soundManager.GetComponent<SoundManager>().BackSound();
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        otetsukiManager.GetComponent<OtetsukiCounter>().PushPause();
    }
}