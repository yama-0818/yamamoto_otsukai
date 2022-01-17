using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class MoveAnim : MonoBehaviour
{
    /// <summary>
    /// 正解時に表示するテキスト
    /// <para>【機能】</para>
    /// <para>・1文字ずつテキストが表示される</para>
    /// <para>・表示後、ファードアウトしていく</para>
    /// </summary>
    public void correctAnim()
    {
        // 当オブジェクトにテキストコンポーネントが入っていれば
        if (gameObject.GetComponent<Text>())
        {
            Text text = gameObject.GetComponent<Text>();

            // テキスト非表示
            text.text = "";

            // テキスト色=>赤
            text.color = Color.red;

            DOTween.Sequence()

                //「せいかい！」と2秒表示させる
                .Append(text.DOText("せいかい", 2f))

                // 「せいかい！」を透明にする
                .Append(text.DOFade(0f, 1f));
        }
    }

    /// <summary>
    /// 不正解時に表示するテキスト
    /// <para>【機能】</para>
    /// <para>・1文字ずつテキストが表示される</para>
    /// <para>・後に1秒かけてフェードアウトしていく</para>
    /// </summary>
    public void wrongAnim()
    {
        // 当オブジェクトにテキストコンポーネントが入っていれば
        if (gameObject.GetComponent<Text>())
        {
            Text text = gameObject.GetComponent<Text>();

            // テキスト非表示
            text.text = "";

            // テキスト色=>青
            text.color = Color.blue;

            DOTween.Sequence()

                //「はずれ！」と2秒表示させる
                .Append(text.DOText("はずれ", 2f))

                // 「はずれ！」を透明にする
                .Append(text.DOFade(0f, 1f));
        }
    }

    
}
