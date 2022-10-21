using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMethodMenu : MonoBehaviour
{
    //操作方法画面の指定
    public GameObject methodMenu;
    //前画面の指定
    //public GameObject beforeMenu;

    void Start()
    {
        methodMenu.SetActive(false);
        //beforeMenu.SetActive(true);
    }
    
    //ポーズメニューを有効にする
    public void open()
    {
        methodMenu.SetActive(true);
        //beforeMenu.SetActive(false);
    }
}
