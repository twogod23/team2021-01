using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameScene1 : MonoBehaviour
{
    //サウンドの指定
    public AudioSource selectSound;
    //ボタンを押したかどうか判定
    private bool pushButton;
    //サウンドを管理するオブジェクトの指定
    private GameObject soundManager;

    void Start()
    {
        //初期化
        pushButton = false;
        soundManager = GameObject.Find("SoundEffects");
    }
    void Update()
    {
        if(!selectSound.isPlaying && pushButton)
        {
            SceneManager.LoadScene("GameScene1");
        }
    }
    
    public void select()
    {
        pushButton = true;
        soundManager.GetComponent<SoundManager>().SelectSound();
    }
}
