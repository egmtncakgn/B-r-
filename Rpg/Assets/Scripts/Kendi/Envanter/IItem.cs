using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;


[System.Serializable]
public class IItem {

    public string itemAdi, itemAciklama;
    public int itemKimlik, itemHasar, itemZirh, itemDeger;
    public Sprite itemİcon;
    public GameObject itemModel;

    public IItemTip itemTip;

    public enum IItemTip
    {
        Silah,
        Zırh,
        Yiyecek,
        Takı,
        Malzeme,
        Boş
    }

    public IItem(string ad, string aciklama, int kimlik, int hasar, int zirh, int deger, IItemTip tip)
    {
        itemAdi = ad;
        itemAciklama = aciklama;
        itemKimlik = kimlik;
        itemHasar = hasar;
        itemZirh = zirh;
        itemDeger = deger;
        itemTip = tip;

        itemİcon = Sprites.İtemİc.load<Sprite>(kimlik.ToString());
        itemModel = Gfx.load<GameObject>("a");
        
    }

    public IItem()
    {

    }
}

