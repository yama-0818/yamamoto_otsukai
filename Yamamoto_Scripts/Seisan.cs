using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seisan : MonoBehaviour
{
    // MyItem参照先
    public MyItem myItem;

    // 結果テキスト
    public Text resultText;

    /// <summary>
    /// 清算ボタン
    /// </summary>
    public void SeisanButton()
    {
        // 処理を呼び出し
        StartCoroutine(Syori());
    }

    IEnumerator Syori()
    {
        // 正解 or 不正解処理(デモ)
        resultText.text = "せいかい";

        // 2秒後
        yield return new WaitForSeconds(2f);

        // 結果を非表示にする
        resultText.text = "";

        // 次の商品計算に行く
        myItem.NextItem();
    }
}
