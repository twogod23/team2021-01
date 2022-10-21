using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMethodMenu : MonoBehaviour
{
    //操作方法画面の指定
    public GameObject methodMenu;
    //前画面の指定
    //public GameObject beforeMenu;

    void Start()
    {
        methodMenu.SetActive(true);
        //beforeMenu.SetActive(false);
    }
    
    //ポーズメニューを無効にする
    public void close()
    {
        methodMenu.SetActive(false);
        //beforeMenu.SetActive(true);
    }
}
