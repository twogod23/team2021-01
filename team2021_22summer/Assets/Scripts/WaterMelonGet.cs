using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WaterMelonGet : MonoBehaviour, IPointerClickHandler
{
    //対象のオブジェクトを指定
    public GameObject watermelon;
    //得点を管理するオブジェクトを指定
    private GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //クリックした際に呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {
        score.GetComponent<Score>().GetWM();
        //オブジェクトを消去
        Destroy(watermelon);
        Debug.Log("click");
    }
}
