using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
    //ポーズメニューを定義
    private GameObject pauseMenu;
    //ポーズメニューのプレハブを定義
    public GameObject pauseMenuPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ポーズメニューの存在の可否でオブジェクトの流れを制御
        pauseMenu = GameObject.Find(pauseMenuPrefab.name);
        if (pauseMenu == null)
        {
            transform.Translate(0.1f, 0, 0); 
        } 
    }
}
