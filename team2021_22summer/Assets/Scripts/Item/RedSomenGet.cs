using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RedSomenGet : MonoBehaviour, IPointerClickHandler
{
    //流すそうめん全体のオブジェクトを指定
    public GameObject redSomen;
    //獲得前のそうめんのモデルを指定
    public GameObject redSomenBefore;
    //獲得後のそうめんのモデルを指定
    public GameObject redSomenAfter;
    //得点を管理するオブジェクトを指定
    private GameObject score;
    //腕の画像を管理するオブジェクトの指定
    private GameObject handcanvas;
    //そうめんの位置を管理
    private Vector3 posRedSomen;
    //獲得後のそうめんのアニメーションを指定
    private Animation redSomenAnime;
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
        redSomenBefore.SetActive(true);
        redSomenAfter.SetActive(false);
        //親オブジェクトのコライダーを有効化
        redSomen.GetComponent<Collider>().enabled = true;
        //水流に伴う動きを有効化
        redSomen.GetComponent<ItemMove>().enabled = true;
        //サウンドを管理するオブジェクトの探索
        soundManager = GameObject.Find("SoundEffects");
    }

    // Update is called once per frame
    void Update()
    {
        if (redSomenAfter.activeSelf == true)
        {
            //そうめんを上に動かす
            redSomen.transform.Translate(Vector3.up * moveUp * Time.deltaTime);
            if (redSomenAnime.isPlaying == false)
            {
                //腕の画像を管理するスクリプトに情報を送信
                handcanvas.GetComponent<ArmManager>().EndSomenAnime();
                //オブジェクトを消去
                Destroy(redSomen);
            }
        }
    }

    //クリックした際に呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {
        if (redSomenBefore.activeSelf == true)
        {
            //得点を管理するスクリプトに情報を送信
            score.GetComponent<Score>().GetRedSomen();
            //腕の画像を管理するスクリプトに情報を送信
            handcanvas.GetComponent<ArmManager>().PlaySomenAnime();
            //そうめんの位置を取得
            posRedSomen = redSomenBefore.transform.position;
            //そうめんのモデルを切り替え
            redSomenBefore.SetActive(false);
            redSomenAfter.SetActive(true);
            //他の獲得後のそうめんのオブジェクトを削除
            var afterSomens = GameObject.FindGameObjectsWithTag("PlayAnimeSomen");
            foreach (var afterSomen in afterSomens)
            {
                Destroy(afterSomen);
            }
            //そうめんのモデルの位置を指定
            redSomenAfter.transform.position = posRedSomen;
            //アニメーションのコンポーネントを取得
            redSomenAnime = redSomenAfter.GetComponent<Animation>();
            //親オブジェクトのコライダーを無効化
            redSomen.GetComponent<Collider>().enabled = false;
            //水流に伴う動きを無効化
            redSomen.GetComponent<ItemMove>().enabled = false;
            //タグの変更
            redSomen.tag = "PlayAnimeSomen";
            //サウンドの再生
            soundManager.GetComponent<SoundManager>().GetSound();
        }
    }
}
