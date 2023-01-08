using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMethodMenu : MonoBehaviour
{
    //操作方法画面の指定
    public GameObject methodMenu;
    //前画面の指定
    //public GameObject beforeMenu;
    //サウンドを管理するオブジェクトの指定
    private GameObject soundManager;

    void Start()
    {
        methodMenu.SetActive(true);
        //beforeMenu.SetActive(false);
        soundManager = GameObject.Find("SoundEffects");
    }
    
    //ポーズメニューを無効にする
    public void close()
    {
        soundManager.GetComponent<SoundManager>().BackSound();
        methodMenu.SetActive(false);
        //beforeMenu.SetActive(true);
    }
}
