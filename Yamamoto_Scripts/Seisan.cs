using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seisan : MonoBehaviour
{
    // MyItem�Q�Ɛ�
    public MyItem myItem;

    // ���ʃe�L�X�g
    public Text resultText;

    /// <summary>
    /// ���Z�{�^��
    /// </summary>
    public void SeisanButton()
    {
        // �������Ăяo��
        StartCoroutine(Syori());
    }

    IEnumerator Syori()
    {
        // ���� or �s��������(�f��)
        resultText.text = "��������";

        // 2�b��
        yield return new WaitForSeconds(2f);

        // ���ʂ��\���ɂ���
        resultText.text = "";

        // ���̏��i�v�Z�ɍs��
        myItem.NextItem();
    }
}
