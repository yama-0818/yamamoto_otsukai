using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct ItemStatus
{
    // ���i�̉摜
    public Sprite productImage;
    
    // ���i�̉��i
    public float price;

    // ���q����̉摜
    public Sprite customerImage;
}

public class OtsukaiMenu : MonoBehaviour
{
    public List<ItemStatus> item;

    // ���݂̏��i�͂���ł��B�Ԙg�\��
    public Image nextBorder;
}