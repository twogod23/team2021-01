using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenuScene : MonoBehaviour
{
    //サウンドの指定
    public AudioSource selectSound;
    //ボタンを押したかどうか判定
    private bool pushButton;
    //ボタンを押した時間を取得
    private float pushTime;

    void Start()
    {
        //初期化
        pushButton = false;
    }
    void Update()
    {
        
        if(pushButton == true)
        {
            if(Time.deltaTime - pushTime > 1.5f)
            {
                SceneManager.LoadScene("MenuScene");
            }
        }
    }
    
    public void select()
    {
        pushButton = true;
        pushTime = Time.deltaTime;
    }
}
