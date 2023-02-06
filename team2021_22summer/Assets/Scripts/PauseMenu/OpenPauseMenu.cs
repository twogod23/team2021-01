using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPauseMenu : MonoBehaviour
{
    //ポーズメニュー画面の指定
    public GameObject pauseMenu;
    //ポーズメニュー画面へ遷移するボタンの指定
    public GameObject pauseButton;
    //サウンドを管理するオブジェクトの指定
    private GameObject soundManager;


    void Start()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        soundManager = GameObject.Find("SoundEffects");
    }
    
    //ポーズメニューを有効にする
    public void open()
    {
        soundManager.GetComponent<SoundManager>().SelectSound();
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
    }
}
