using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct ItemStatus
{
    // 商品の画像
    public Sprite productImage;
    
    // 商品の価格
    public float price;

    // お客さんの画像
    public Sprite customerImage;
}

public class OtsukaiMenu : MonoBehaviour
{
    public List<ItemStatus> item;

    // 現在の商品はこれです。赤枠表示
    public Image nextBorder;
}