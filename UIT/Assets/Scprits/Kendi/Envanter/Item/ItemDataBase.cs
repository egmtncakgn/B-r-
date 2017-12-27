using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemDataBase : MonoBehaviour
{

    public List<Item> itemler;

    void Awake()
    {
        itemler.Add(new Item("", "", 0, 0, 0,0,0, 0, Item.ItemTip.Boş));
        itemler.Add(new Item("Kılıj", "Saldırı", 1, 10, 0, 1,1,10, Item.ItemTip.Silah));
        itemler.Add(new Item("Zırh", "Savunma", 2, 0, 10, 1,5,10, Item.ItemTip.Zırh));
        itemler.Add(new Item("Demir", "Kılıç Yapılabilir", 3, 0, 0, 5,10,10, Item.ItemTip.Malzeme));
        itemler.Add(new Item("Kolye", "Güzel Görünür", 4, 0, 0, 1,20,1, Item.ItemTip.Takı));
        itemler.Add(new Item("Elma", "Acıkırsan Ye", 5, 0, 0, 2,25,2, Item.ItemTip.Yiyecek));
    }
}
