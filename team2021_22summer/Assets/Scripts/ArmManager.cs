using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmManager : MonoBehaviour
{
    //腕の画像を指定
    public GameObject armImage;

    //そうめん獲得時のアニメーション再生の際に呼び出し
    public void PlaySomenAnime()
    {
        //腕の画像を非表示
        armImage.SetActive(false);   
    }

    //そうめん獲得時のアニメーション再生の際に呼び出し
    public void EndSomenAnime()
    {
        //腕の画像を表示
        armImage.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        //腕の画像を表示
        armImage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
