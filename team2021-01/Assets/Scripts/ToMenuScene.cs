using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenuScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ボタン操作
    public void Select()
    {
        //ゲームシーンに移動
        SceneManager.LoadScene("GameScene");
    }
}
