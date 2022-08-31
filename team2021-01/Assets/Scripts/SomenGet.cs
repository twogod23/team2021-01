using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SomenGet : MonoBehaviour, IPointerClickHandler
{
    //対象のオブジェクトを指定
    public GameObject somen;
    //得点を管理するオブジェクトを指定
    public GameObject score;

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
        score.GetComponent<Score>().GetSomen();
        //オブジェクトを消去
        Destroy(somen);
        Debug.Log("click");
    }
}
