using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyItem : MonoBehaviour
{
    // アイテム一覧表の参照先指定
    public OtsukaiMenu itemSystem;

    // 自身が何番であるか(リストの番号と同期)
    public int myNumber;

    [Header("UI")]
    // 製品の画像
    public Image productImage;

    // 価格のテキスト
    public List<Text> priceText = null;

    // お客様の画像
    public Image customerImage;

    // 吹き出しオブジェクトであるかどうか
    public bool hukidasshi;

    // 最初の実行か否か
    bool firstSet = true;

    void Start()
    {
        // 最初の実行でNextItemを呼ぶ
        NextItem();
    }

    public void NextItem()
    {
        // 2回目以降であれば、ListのRemove処理をする
        if (!firstSet)
        {
            // リストの0を削除する(支払い済みの商品を削除)
            itemSystem.item.Remove(itemSystem.item[0]);

            // 赤枠を移動させる(次の商品へ)
            itemSystem.nextBorder.transform.localPosition += new Vector3(100, 0, 0);
        }

        // 画像をitemSystemから取得、反映(表示)
        productImage.sprite = itemSystem.item[myNumber].productImage;
        
        // 価格をitemSystemから取得、反映(表示)
        priceText[0].text = itemSystem.item[myNumber].price + "円".ToString();
        
        // アタッチ先が吹き出しUIであれば、
        if (hukidasshi)
        {
            // テキスト2にヒントテキストを表示させる
            priceText[1].text = "＼ " + priceText[0].text + "はらってね！／".ToString();

            // お客さんをitemSystemから取得、反映(表示)
            customerImage.sprite = itemSystem.item[myNumber].customerImage;
        }

        // 最初の呼び出し終了
        firstSet = false;

        // ログ監視用
        Debug.Log(productImage.sprite.name + priceText[0].text);
    }
}
