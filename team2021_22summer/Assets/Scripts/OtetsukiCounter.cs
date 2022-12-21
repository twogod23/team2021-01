using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtetsukiCounter : MonoBehaviour
{
    //クリックした回数をカウント
    private int clickCounter;
    //アイテムを取得した回数をカウント
    private int getCounter;
    

    //取得したアイテムの数をカウント
    public void GetItem()
    {
        getCounter += 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        //初期化
        clickCounter = 0;
        getCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
