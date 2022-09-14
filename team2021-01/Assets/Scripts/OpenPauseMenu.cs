using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenPauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    void Start()
    {
        pauseMenu.SetActive(false);
    }
    
    //ポーズメニューを有効にする
    public void open()
    {
        pauseMenu.SetActive(true);
    }

    //ポーズメニューを無効にする
    public void close()
    {
        pauseMenu.SetActive(false);
    }
}
