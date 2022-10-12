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
    //アイテムのRigidBodyを取得
    private Rigidbody rbItem;
    //取得済みかどうかを判定
    private bool gotItem = false;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score");
        rbItem = GetComponentInChildren<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gotItem == true)
        {
            rbItem.AddForce(Vector3.up * 100.0f);
        }
    }

    //クリックした際に呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {
        if (gotItem == false)
        {
            //取得済みと判定
            gotItem = true;
            //アイテムを流すスクリプトを停止
            watermelon.GetComponent<ItemMove>().enabled = false;
            //加点作業
            score.GetComponent<Score>().GetWM();
        }
        //オブジェクトを消去
        //Destroy(watermelon);
        Debug.Log("click");
    }
}
