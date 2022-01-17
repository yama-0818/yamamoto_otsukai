using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyItem : MonoBehaviour
{
    // �A�C�e���ꗗ�\�̎Q�Ɛ�w��
    public OtsukaiMenu itemSystem;

    // ���g�����Ԃł��邩(���X�g�̔ԍ��Ɠ���)
    public int myNumber;

    [Header("UI")]
    // ���i�̉摜
    public Image productImage;

    // ���i�̃e�L�X�g
    public List<Text> priceText = null;

    // ���q�l�̉摜
    public Image customerImage;

    // �����o���I�u�W�F�N�g�ł��邩�ǂ���
    public bool hukidasshi;

    // �ŏ��̎��s���ۂ�
    bool firstSet = true;

    void Start()
    {
        // �ŏ��̎��s��NextItem���Ă�
        NextItem();
    }

    public void NextItem()
    {
        // 2��ڈȍ~�ł���΁AList��Remove����������
        if (!firstSet)
        {
            // ���X�g��0���폜����(�x�����ς݂̏��i���폜)
            itemSystem.item.Remove(itemSystem.item[0]);

            // �Ԙg���ړ�������(���̏��i��)
            itemSystem.nextBorder.transform.localPosition += new Vector3(100, 0, 0);
        }

        // �摜��itemSystem����擾�A���f(�\��)
        productImage.sprite = itemSystem.item[myNumber].productImage;
        
        // ���i��itemSystem����擾�A���f(�\��)
        priceText[0].text = itemSystem.item[myNumber].price + "�~".ToString();
        
        // �A�^�b�`�悪�����o��UI�ł���΁A
        if (hukidasshi)
        {
            // �e�L�X�g2�Ƀq���g�e�L�X�g��\��������
            priceText[1].text = "�_ " + priceText[0].text + "�͂���ĂˁI�^".ToString();

            // ���q�����itemSystem����擾�A���f(�\��)
            customerImage.sprite = itemSystem.item[myNumber].customerImage;
        }

        // �ŏ��̌Ăяo���I��
        firstSet = false;

        // ���O�Ď��p
        Debug.Log(productImage.sprite.name + priceText[0].text);
    }
}
