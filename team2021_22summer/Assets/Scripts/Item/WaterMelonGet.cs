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
    //コライダーを取得
    private Collider parentCollider;
    private Collider childCollider;
    //取得済みかどうかを判定
    private bool gotItem = false;
    //アイテム取得時間を管理
    private float afterGetTime;
    //すいかを持ち上げる力を設定
    [SerializeField] private float moveUp;
    //最初にすいかを持ち上げる力を設定
    [SerializeField] private float startMoveUp;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score");
        rbItem = GetComponentInChildren<Rigidbody>();
        parentCollider = GetComponent<Collider>();
        childCollider = GetComponentInChildren<Collider>();
        afterGetTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gotItem == true)
        {
            //力をかけてすいかを上に持ち上げる
            rbItem.AddForce(Vector3.up * moveUp);
            //一定時間後にアイテムを削除
            float time = afterGetTime - Timer.GetTime();
            if (time > 2.0f)
            {
                Destroy(watermelon);
            }
            
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
            //判定用のコライダーを削除
            parentCollider.enabled = false;
            childCollider.enabled = false;
            //アイテム取得時間を取得
            afterGetTime = Timer.GetTime();
            //かかる力をゼロにする
            rbItem.velocity = Vector3.zero;
            //最初に上向きに力を加える
            rbItem.AddForce(Vector3.up * startMoveUp);
        }
        Debug.Log("click");
    }
}
