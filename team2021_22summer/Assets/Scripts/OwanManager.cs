using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwanManager : MonoBehaviour
{
    //空のお椀を指定
    public GameObject owanEmpty;
    //そうめんの入ったお椀の指定
    public GameObject owanInSomen;
    //赤いそうめんの入ったお椀の指定
    public GameObject owanInRedSomen;

    //直近で獲得したアイテムを判定
    private string inItem;
    
    // Start is called before the first frame update
    void Start()
    {
        //お椀の初期画像を表示
        owanEmpty.SetActive(true);
        owanInSomen.SetActive(false);
        owanInRedSomen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //直近で獲得したアイテムによってお椀の画像　を制御
        inItem = Score.GetInSomen();
        //そうめんの場合
        if (inItem == "Somen")
        {
            //そうめん入りのお椀の画像を表示
            owanEmpty.SetActive(false);
            owanInSomen.SetActive(true);
            owanInRedSomen.SetActive(false);
        }
        else if (inItem == "RedSomen")
        {
            //そうめん入りのお椀の画像を表示
            owanEmpty.SetActive(false);
            owanInSomen.SetActive(false);
            owanInRedSomen.SetActive(true);
        }
    }
}
