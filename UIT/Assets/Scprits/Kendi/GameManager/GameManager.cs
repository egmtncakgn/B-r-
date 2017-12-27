using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	
	public bool _Envanter;
	public GameObject envanter;
	
	Ray ray;
	RaycastHit hit;
	
	
	void Update () 
	{
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		if (_Envanter)
		{
			envanter.SetActive(true);
		}
		else
		{
			envanter.SetActive(false);
		}
		
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			_Envanter = !_Envanter;
		}
		
		if (Physics.Raycast(ray, out hit, 5))
		{
			if(hit.transform.gameObject.tag == "DropItem")
			{
				if (Input.GetKeyDown(KeyCode.E))
				{
					envanter.GetComponent<Envanter>().ItemEkleme(hit.transform.GetComponent<DropItemObj>().item.itemKimlik, hit.transform.GetComponent<DropItemObj>().item.itemDeger);
				    Destroy(hit.transform.gameObject);
				}
			}	
		}	 
	}
}
