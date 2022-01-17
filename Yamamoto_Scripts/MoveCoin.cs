using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

// AudioSource,Transform,SpriteRendererが入っていなければ、
// 自動で入れる(アタッチ忘れ防止)
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(SpriteRenderer))]
public class MoveCoin : MonoBehaviour
{
    AudioSource audioSource;
    
    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

        // AudioSource最初に再生する機能をオフにする
        audioSource.playOnAwake = false;

        // AudioSourceのクリップに自動でCoinTos(AudioClip)を入れる
        // CoinTos(AudioClip)場所はResourceフォルダの中
        audioSource.clip = Resources.Load("CoinTos", typeof(AudioClip)) as AudioClip;
    }

    /// <summary>
    /// コインが弾かれて下に落ちていき、消える
    /// <para>【機能】</para>
    /// <para>・Y軸-5.5f地点に2秒かけて移動</para>
    /// <para>・コイン画像を0.5秒かけてフェードアウト</para>
    /// <para>・後にオブジェクトが破壊される</para>
    /// </summary>
    public void moveCoinAnim()
    {
        // 当オブジェクトにTransformとSpriteRendererコンポーネントが入っていれば
        if (gameObject.GetComponent<Transform>() && gameObject.GetComponent<SpriteRenderer>())
        {
            // 当オブジェクトのX軸を取得
            float posx = this.gameObject.transform.position.x;

            // 当オブジェクトにAudioSourceが入って入れば
            if (gameObject.GetComponent<AudioSource>())
            {
                // お金が落ちた音を1度だけ鳴らす
                audioSource.Play();
            }

            DOTween.Sequence()
                // Y軸を-5.5fに1秒かけて移動させる
                .Append(gameObject.transform.DOMove(new Vector2(posx, -5.5f), 1f))

                // 画像を0.5秒かけてフェードアウトさせる
                .Append(gameObject.GetComponent<SpriteRenderer>().DOFade(0f, 0.5f))

                // 後に当ゲームオブジェクトを破壊する
                .AppendCallback(() =>
                {
                    Destroy(this.gameObject);
                });
        }
    }
}
