using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropItem : MonoBehaviour, IPointerDownHandler {
	
	public GameObject oyuncu;
	public Envanter env;
	
	void Start()
	{
		
	}

	public void ItemDrop(Item item)
	{
		GameObject go = (GameObject)Instantiate(item.itemModel, oyuncu.transform.position, oyuncu.transform.rotation);
	    go.GetComponent<Rigidbody>().AddForce(Vector3.forward * 1);
		go.GetComponent<DropItemObj>().item = item;
		go.name = item.itemAdi;
	}
	
	public void OnPointerDown(PointerEventData data)
	{
		if(data.button.ToString() == "Left")
		{
			if(env.surukleItemBool)
			{
				ItemDrop(env.surukleItem);
				env.SuruklenenGizle();
			}
		}
	}
}
