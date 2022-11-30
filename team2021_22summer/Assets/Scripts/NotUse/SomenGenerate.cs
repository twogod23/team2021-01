using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SomenGenerate : MonoBehaviour
{
    //生成するアイテムを定義
    public GameObject prefabSomen;
    //生成するアイテムの数を指定
    private int ItemNum = 20;
    //アイテムを生成する時間の最大値を指定
    private float LimitTime = 115.0f;
    //アイテムを生成する時間を格納する配列
    private float[] ItemTime;
    //配列の要素を管理する番号
    private int ArrayNum;
    //時間を管理
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        //配列の生成
        ItemTime = new float[ItemNum];

        //時間の格納
        for(ArrayNum = 0; ArrayNum < ItemNum; ArrayNum++)
        {
            ItemTime[ArrayNum] = UnityEngine.Random.Range(0.0f, LimitTime);
        }

        //配列のソート
        Array.Sort(ItemTime);

        for(int i = 0; i < ItemNum; i++){
            Debug.Log(ItemTime[i]);
        }

        ArrayNum = ItemNum - 1;
    }

    // Update is called once per frame
    void Update()
    {
        //時間の取得
        time = Timer.GetTime();
        
        if(ArrayNum >= 0)
        {
            //アイテムの生成
            if(ItemTime[ArrayNum] >= time)
            {
                Instantiate(prefabSomen);
                ArrayNum--;
            }
        }
    }
}
