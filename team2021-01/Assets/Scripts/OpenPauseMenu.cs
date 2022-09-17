using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPauseMenu : MonoBehaviour
{
    //ポーズメニュー画面の指定
    public GameObject pauseMenu;
    //ポーズメニュー画面へ遷移するボタンの指定
    public GameObject pauseButton;

    void Start()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
    }
    
    //ポーズメニューを有効にする
    public void open()
    {
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
    }
}
