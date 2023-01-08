using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMethodMenu : MonoBehaviour
{
    //操作方法画面の指定
    public GameObject methodMenu;
    //前画面の指定
    //public GameObject beforeMenu;
    //サウンドを管理するオブジェクトの指定
    private GameObject soundManager;

    void Start()
    {
        methodMenu.SetActive(false);
        //beforeMenu.SetActive(true);
        soundManager = GameObject.Find("SoundEffects");
    }
    
    //ポーズメニューを有効にする
    public void open()
    {
        soundManager.GetComponent<SoundManager>().SelectSound();
        methodMenu.SetActive(true);
        //beforeMenu.SetActive(false);
    }
}
