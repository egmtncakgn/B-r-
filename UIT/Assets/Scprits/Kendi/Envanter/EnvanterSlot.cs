using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class EnvanterSlot : MonoBehaviour,
    IPointerEnterHandler,
    IPointerExitHandler,
    IPointerDownHandler,
    IDragHandler
{

    public Item item;
    public int slotSayi;

    public Envanter envanter;

    public Image itemResim;
    public Text itemDeger;

    void Start()
    {
        envanter = GameObject.FindGameObjectWithTag("Envanter").GetComponent<Envanter>();
        itemResim = transform.GetChild(0).GetComponent<Image>();
        itemDeger = transform.GetChild(1).GetComponent<Text>();
    }
    void Update()
    {
        item = envanter.itemler[slotSayi];
        if (item.itemAdi != null)
        {
            itemResim.enabled = true;
            itemDeger.enabled = true;
            itemResim.sprite = item.itemIcon;
            itemDeger.text = item.itemDeger.ToString();
        }
        else
        {
            itemResim.enabled = false;
            itemDeger.enabled = false;
        }
        
        if(item.itemDeger > 1)
        {
            itemDeger.enabled = true;
        }
        else
        {
            itemDeger.enabled = false;
        }
        
    }
    public void OnPointerEnter(PointerEventData data)
    {
        if (item.itemAdi != null)
        {
            envanter.ToolTipGoster(item);
        }
    }
    public void OnPointerExit(PointerEventData data)
    {
        envanter.GizleToolTip();
    }
    public void OnPointerDown(PointerEventData data)
    {
        if (data.button.ToString() == "Left")
        {
            if (!envanter.surukleItemBool)
            {
                envanter.SuruklenenGoster(item);
                envanter.itemler[slotSayi] = new Item();
            }
            else if(envanter.surukleItemBool)
            {
                if (item.itemAdi == null)
                {
                    envanter.itemler[slotSayi] = envanter.surukleItem;
                    envanter.SuruklenenGizle();
                }
                else if (item.itemAdi != null)
                {
                    if (item.itemTip == Item.ItemTip.Yiyecek)
					{
						if (item.itemAdi == envanter.surukleItem.itemAdi)
						{
							envanter.itemler[slotSayi].itemDeger += envanter.surukleItem.itemDeger;
							envanter.SuruklenenGizle();
						}
					}
					else
					{
						Item newItem = envanter.itemler[slotSayi];
					    envanter.itemler[slotSayi] = envanter.surukleItem;
					    envanter.surukleItem = newItem;
					}
                }
            }
        }
		if (data.button.ToString() == "Right")
		{
			if (!envanter.surukleItemBool)
            {
				if (item.itemTip == Item.ItemTip.Yiyecek)
				{
					int value = item.itemDeger / 2;					
					Item newItem = new Item(item.itemAdi, item.itemAciklama, item.itemKimlik, item.itemHasar, item.itemZirh, item.itemDeger, item.itemMaxStok, item.itemAgirlik, item.itemTip);
					envanter.SuruklenenGoster(newItem);
					int value2 = item.itemDeger - value;
					envanter.itemler[slotSayi].itemDeger = value2;
				}
            }
            else if(envanter.surukleItemBool)
            {
                
            }
		}
    }
    public void OnDrag(PointerEventData data)
    {

    }

} 
