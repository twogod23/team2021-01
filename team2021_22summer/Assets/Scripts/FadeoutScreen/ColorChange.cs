using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    //色を表示する画像の定義
    [SerializeField] private GameObject colorImage;
    //色を示す変数の定義
    private Color color;

    // Start is called before the first frame update
    void Start()
    {
        //色の初期値を設定
        color.r = 0.0f;
        color.g = 0.0f;
        color.b = 0.0f;
        color.a = 0.0f;
        colorImage.GetComponent<Image>().color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if (color.a < 1.0f)
        {
            //フレーム毎に画面を暗くする
            color.a += 0.05f;
            colorImage.GetComponent<Image>().color = color;
        }
    }
}
