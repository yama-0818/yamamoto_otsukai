using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class MoveAnim : MonoBehaviour
{
    /// <summary>
    /// �������ɕ\������e�L�X�g
    /// <para>�y�@�\�z</para>
    /// <para>�E1�������e�L�X�g���\�������</para>
    /// <para>�E�\����A�t�@�[�h�A�E�g���Ă���</para>
    /// </summary>
    public void correctAnim()
    {
        // ���I�u�W�F�N�g�Ƀe�L�X�g�R���|�[�l���g�������Ă����
        if (gameObject.GetComponent<Text>())
        {
            Text text = gameObject.GetComponent<Text>();

            // �e�L�X�g��\��
            text.text = "";

            // �e�L�X�g�F=>��
            text.color = Color.red;

            DOTween.Sequence()

                //�u���������I�v��2�b�\��������
                .Append(text.DOText("��������", 2f))

                // �u���������I�v�𓧖��ɂ���
                .Append(text.DOFade(0f, 1f));
        }
    }

    /// <summary>
    /// �s�������ɕ\������e�L�X�g
    /// <para>�y�@�\�z</para>
    /// <para>�E1�������e�L�X�g���\�������</para>
    /// <para>�E���1�b�����ăt�F�[�h�A�E�g���Ă���</para>
    /// </summary>
    public void wrongAnim()
    {
        // ���I�u�W�F�N�g�Ƀe�L�X�g�R���|�[�l���g�������Ă����
        if (gameObject.GetComponent<Text>())
        {
            Text text = gameObject.GetComponent<Text>();

            // �e�L�X�g��\��
            text.text = "";

            // �e�L�X�g�F=>��
            text.color = Color.blue;

            DOTween.Sequence()

                //�u�͂���I�v��2�b�\��������
                .Append(text.DOText("�͂���", 2f))

                // �u�͂���I�v�𓧖��ɂ���
                .Append(text.DOFade(0f, 1f));
        }
    }

    
}
