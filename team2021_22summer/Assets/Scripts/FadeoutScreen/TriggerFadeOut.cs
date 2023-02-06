using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFadeOut : MonoBehaviour
{
    //フェードアウトに用いる画面のゲームオブジェクトを定義
    [SerializeField] private GameObject fadeOutScreen;

    // Start is called before the first frame update
    void Start()
    {
        fadeOutScreen.SetActive(false);
    }

    public void Select()
    {
        fadeOutScreen.SetActive(true);
        Debug.Log("select");
    }
}
