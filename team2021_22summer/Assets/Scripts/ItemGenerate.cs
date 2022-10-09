using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerate : MonoBehaviour
{
    //生成するアイテムを定義
        //そうめん
        public GameObject prefabSomen;
        //赤いそうめん
        public GameObject prefabRedSomen;
        //スイカ
        public GameObject prefabWM;

    //アイテムを生成する時間の配列
    private float[] itemTime = 
    {
        0.0f,
        10.0f,
        20.0f,
        30.0f,
        40.0f,
        50.0f,
        60.0f,
        70.0f,
        80.0f,
        90.0f,
        100.0f,
        110.0f, 117.0f
    };

    //生成するアイテムを指定する配列
    private string[] itemSelect;

    //生成するアイテムの総数を格納
    private int itemTotal;

    //生成するアイテムの個数を指定
        //そうめん
        private int somenNum = 7;
        //赤いそうめん
        private int redsomenNum = 4;
        //スイカ
        private int wmNum = 2;

    //配列の要素番号を管理
    private int itemNum;

    //時間を管理
    private float time;


    // Start is called before the first frame update
    void Start()
    {
        //アイテムの総数を指定
        itemTotal = itemTime.Length;
        //配列の生成
        itemSelect = new string[itemTotal];
        //配列の要素番号の初期化
        itemNum = 0;

        //アイテムを指定する配列の生成
        if (itemTotal == somenNum + redsomenNum + wmNum)
        {
            //そうめん
            for (int i = 0; i < somenNum; i++)
            {
                itemSelect[itemNum] = "Somen";
                itemNum++;
            }
            //赤いそうめん
            for (int i = 0; i < redsomenNum; i++)
            {
                itemSelect[itemNum] = "RedSomen";
                itemNum++;
            }
            //スイカ
            for (int i = 0; i < wmNum; i++)
            {
                itemSelect[itemNum] = "WM";
                itemNum++;
            }

            //アイテムをランダムに並べ替え　フィッシャー イェーツのシャッフル
            for (int i = itemTotal - 1; i > 0; --i)
            {
                //ランダムな整数を取得
                int j = Random.Range(0, i + 1);
                //要素の交換
                string arrayItem = itemSelect[i];
                itemSelect[i] = itemSelect[j];
                itemSelect[j] = arrayItem;
            }

            //配列の要素番号を補正
            itemNum--;
        }
        else
        {
            Debug.Log("アイテムの数と設定した時間の数が一致しません" + "アイテム：" + (somenNum + redsomenNum + wmNum) + " 時間：" + itemTotal);
        }

    }


    // Update is called once per frame
    void Update()
    {
        //時間の取得
        time = Timer.GetTime();

        //アイテムの生成
        if (itemNum >= 0)
        {
            //指定時間になったらアイテムを生成
            if (itemTime[itemNum] >= time)
            {
                //生成するアイテムの種類による条件分岐
                switch (itemSelect[itemNum])
                {
                    //そうめん
                    case "Somen":
                       Instantiate(prefabSomen);
                       break;
                    //赤いそうめん
                    case "RedSomen":
                        Instantiate(prefabRedSomen);
                        break;
                    //すいか
                    case "WM":
                        Instantiate(prefabWM);
                        break;
                    //その他
                    default:
                        break;
                }
                
                itemNum--;
            }
        }
    }
}
