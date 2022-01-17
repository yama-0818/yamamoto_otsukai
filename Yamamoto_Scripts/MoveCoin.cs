using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

// AudioSource,Transform,SpriteRenderer�������Ă��Ȃ���΁A
// �����œ����(�A�^�b�`�Y��h�~)
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(SpriteRenderer))]
public class MoveCoin : MonoBehaviour
{
    AudioSource audioSource;
    
    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

        // AudioSource�ŏ��ɍĐ�����@�\���I�t�ɂ���
        audioSource.playOnAwake = false;

        // AudioSource�̃N���b�v�Ɏ�����CoinTos(AudioClip)������
        // CoinTos(AudioClip)�ꏊ��Resource�t�H���_�̒�
        audioSource.clip = Resources.Load("CoinTos", typeof(AudioClip)) as AudioClip;
    }

    /// <summary>
    /// �R�C�����e����ĉ��ɗ����Ă����A������
    /// <para>�y�@�\�z</para>
    /// <para>�EY��-5.5f�n�_��2�b�����Ĉړ�</para>
    /// <para>�E�R�C���摜��0.5�b�����ăt�F�[�h�A�E�g</para>
    /// <para>�E��ɃI�u�W�F�N�g���j�󂳂��</para>
    /// </summary>
    public void moveCoinAnim()
    {
        // ���I�u�W�F�N�g��Transform��SpriteRenderer�R���|�[�l���g�������Ă����
        if (gameObject.GetComponent<Transform>() && gameObject.GetComponent<SpriteRenderer>())
        {
            // ���I�u�W�F�N�g��X�����擾
            float posx = this.gameObject.transform.position.x;

            // ���I�u�W�F�N�g��AudioSource�������ē����
            if (gameObject.GetComponent<AudioSource>())
            {
                // ����������������1�x�����炷
                audioSource.Play();
            }

            DOTween.Sequence()
                // Y����-5.5f��1�b�����Ĉړ�������
                .Append(gameObject.transform.DOMove(new Vector2(posx, -5.5f), 1f))

                // �摜��0.5�b�����ăt�F�[�h�A�E�g������
                .Append(gameObject.GetComponent<SpriteRenderer>().DOFade(0f, 0.5f))

                // ��ɓ��Q�[���I�u�W�F�N�g��j�󂷂�
                .AppendCallback(() =>
                {
                    Destroy(this.gameObject);
                });
        }
    }
}
