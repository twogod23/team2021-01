using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSound : MonoBehaviour
{
    //サウンドを管理するゲームオブジェクトを定義
    public GameObject soundManager;

    //ボタンを押した際にサウンドを呼び出し
    public void Select()
    {
        soundManager.GetComponent<SoundManager>().SelectSound();
    }
}
