using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwanManager : MonoBehaviour
{
    //空のお椀を指定
    public GameObject owanEmpty;
    //そうめんの入ったお椀の指定
    public GameObject owanInSomen;
    //そうめんの有無を判定
    private string inSomen;
    // Start is called before the first frame update
    void Start()
    {
        //お椀の初期画像を表示
        owanEmpty.SetActive(true);
        owanInSomen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        inSomen = Score.GetInSomen();
        if (inSomen == "true")
        {
            //お椀の初期画像を表示
            owanEmpty.SetActive(false);
            owanInSomen.SetActive(true);
        }
    }
}
