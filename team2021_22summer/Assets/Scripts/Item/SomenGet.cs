using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SomenGet : MonoBehaviour, IPointerClickHandler
{
    //流すそうめん全体のオブジェクトを指定
    public GameObject somen;
    //獲得前のそうめんのモデルを指定
    public GameObject somenBefore;
    //獲得後のそうめんのモデルを指定
    public GameObject somenAfter;
    //得点を管理するオブジェクトを指定
    private GameObject score;
    //腕の画像を管理するオブジェクトの指定
    private GameObject handcanvas;
    //そうめんの位置を管理
    private Vector3 posSomen;
    //獲得後のそうめんのアニメーションを指定
    private Animation somenAnime;
    ///獲得後のそうめんを持ち上げる力を設定
    [SerializeField] private float moveUp;
    //サウンドを管理するオブジェクトの指定
    private GameObject soundManager;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score");
        handcanvas = GameObject.Find("HandCanvas");
        //そうめんのモデル
        somenBefore.SetActive(true);
        somenAfter.SetActive(false);
        //親オブジェクトのコライダーを有効化
        somen.GetComponent<Collider>().enabled = true;
        //水流に伴う動きを有効化
        somen.GetComponent<ItemMove>().enabled = true;
        //サウンドを管理するオブジェクトの探索
        soundManager = GameObject.Find("SoundEffects");
    }

    // Update is called once per frame
    void Update()
    {
        if (somenAfter.activeSelf == true)
        {
            //そうめんを上に動かす
            somen.transform.Translate(Vector3.up * moveUp);
            if (somenAnime.isPlaying == false)
            {
                //腕の画像を管理するスクリプトに情報を送信
                handcanvas.GetComponent<ArmManager>().EndSomenAnime();
                //オブジェクトを消去
                Destroy(somen);
            }
        }
    }

    //クリックした際に呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {
        if (somenBefore.activeSelf == true)
        {
            //得点を管理するスクリプトに情報を送信
            score.GetComponent<Score>().GetSomen();
            //腕の画像を管理するスクリプトに情報を送信
            handcanvas.GetComponent<ArmManager>().PlaySomenAnime();
            //そうめんの位置を取得
            posSomen = somenBefore.transform.position;
            //そうめんのモデルを切り替え
            somenBefore.SetActive(false);
            somenAfter.SetActive(true);
            //他の獲得後のそうめんのオブジェクトを削除
            var afterSomens = GameObject.FindGameObjectsWithTag("PlayAnimeSomen");
            foreach (var afterSomen in afterSomens)
            {
                Destroy(afterSomen);
            }
            //そうめんのモデルの位置を指定
            somenAfter.transform.position = posSomen;
            //アニメーションのコンポーネントを取得
            somenAnime = somenAfter.GetComponent<Animation>();
            //親オブジェクトのコライダーを無効化
            somen.GetComponent<Collider>().enabled = false;
            //水流に伴う動きを無効化
            somen.GetComponent<ItemMove>().enabled = false;
            //タグの変更
            somen.tag = "PlayAnimeSomen";
            //サウンドの再生
            soundManager.GetComponent<SoundManager>().GetSound();
        }
    }
}
