using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;


[System.Serializable]
public class Item
{

    public string itemAdi, itemAciklama;
    public int itemKimlik, itemHasar, itemZirh, itemDeger, itemMaxStok, itemAgirlik;
    public Sprite itemIcon;
    public GameObject itemModel;

    public ItemTip itemTip;

    public enum ItemTip
    {
        Silah,
        Zırh,
        Yiyecek,
        Takı,
        Malzeme,
        Boş
    }

    public Item(string ad, string aciklama, int kimlik, int hasar, int zirh, int deger,int maxStok,int agirlik, ItemTip tip)
    {
        itemAdi = ad;
        itemAciklama = aciklama;
        itemKimlik = kimlik;
        itemHasar = hasar;
        itemZirh = zirh;
        itemDeger = deger;
        itemMaxStok = maxStok;
        itemAgirlik = agirlik;
        itemTip = tip;

        itemIcon = Resources.Load<Sprite>(kimlik.ToString());
        itemModel = Resources.Load<GameObject>("a");
        
    }

    public Item()
    {

    }
}

