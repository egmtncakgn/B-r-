using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Envanter : MonoBehaviour {

    public List<Item> itemler;
    public GameObject slot, toolTip, surukleItemObj;
    public ItemDataBase dataBase;

    public bool toolTipBool, surukleItemBool;
    public Item toolTipItem, surukleItem;

    void Start()
    {
        dataBase = GameObject.FindGameObjectWithTag("ItemDataBase").GetComponent<ItemDataBase>();

        for(int i = 0; i<25; i++)
        {
            GameObject slots = (GameObject)Instantiate(slot);
            slots.transform.SetParent(this.gameObject.transform);
            slots.GetComponent<EnvanterSlot>().slotSayi = i;
            slots.name = "Slot" + i;
            itemler.Add(new Item());
        }

        ItemEkleme(3, 4);
        ItemEkleme(5, 4);
        ItemEkleme(1, 4);
        ItemEkleme(5, 4);

    }

    void Update()
    {
        if (toolTipBool)
        {
            toolTip.transform.GetChild(0).GetComponent<Text>().text = toolTipItem.itemAdi;
            toolTip.transform.GetChild(1).GetComponent<Text>().text = toolTipItem.itemAciklama;
            toolTip.gameObject.GetComponent<RectTransform>().position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        }

        if (surukleItemBool)
        {
            surukleItemObj.transform.GetChild(0).GetComponent<Image>().sprite = surukleItem.itemIcon;
            surukleItemObj.transform.GetChild(1).GetComponent<Text>().text = surukleItem.itemDeger.ToString();
            surukleItemObj.gameObject.GetComponent<RectTransform>().position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        }
        
    }

    public void SuruklenenGoster(Item item)
    {
        surukleItem = item;
        surukleItemBool = true;
        surukleItemObj.SetActive(true);
    }
    public void SuruklenenGizle()
    {
        surukleItemBool = false;
        surukleItemObj.SetActive(false);
    }

    public void ToolTipGoster(Item item)
    {
        toolTipItem = item;
        toolTipBool = true;
        toolTip.SetActive(true);
    }

    public void GizleToolTip()
    {
        toolTipBool = false;
        toolTip.SetActive(false);
    }

    public void ItemEkleme(int kimlik, int deger)
    {
        for(int i = 0; i < dataBase.itemler.Count; i++)
        {
            if(dataBase.itemler[i].itemKimlik == kimlik)
            {
                Item item = new Item(dataBase.itemler[i].itemAdi, 
                                     dataBase.itemler[i].itemAciklama,
                                     dataBase.itemler[i].itemKimlik,
                                     dataBase.itemler[i].itemHasar,
                                     dataBase.itemler[i].itemZirh,
                                     deger,
                                     dataBase.itemler[i].itemMaxStok,
                                     dataBase.itemler[i].itemAgirlik,
                                     dataBase.itemler[i].itemTip);
                if(item.itemTip == Item.ItemTip.Yiyecek)
                {
                    UstuneEkleme(item);
                    break;
                }
                else
                {
                    BosSlotaItemEkle(item);
                    break;
                }
                
            }
        }
    }

    void UstuneEkleme(Item item)
    {
        for(int i =0; i < itemler.Count; i++)
        {
            if(itemler[i].itemKimlik == item.itemKimlik)
            {
                itemler[i].itemDeger += item.itemDeger;
                break;
            }
            else if(i == itemler.Count - 1)
            {
                BosSlotaItemEkle(item);
                break;
            }
        }
    }

    void BosSlotaItemEkle(Item item)
    {
        for (int i = 0; i < itemler.Count; i++)
        {
            if(itemler[i].itemAdi == null)
            {
                itemler[i] = item;
                break;
            }
        } 
    }
}
