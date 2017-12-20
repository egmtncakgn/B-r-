using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

    public Button envanter, karakter, ayarlar, b1, b2;
    public GameObject epanel, kpanel, apanel, ab1, bb2;
    public int eint, kint, aint, abint, bbint;
    

	// Use this for initialization
	void Start () {

        epanel.SetActive(false);
        kpanel.SetActive(false);
        apanel.SetActive(false);
        ab1.SetActive(false);
        bb2.SetActive(false);
    }

    public void EPanel()
    {
        ++eint;
    }
    public void KPanel()
    {


    }
    public void APanel()
    {


    }
    public void AB1()
    {


    }
    public void BB2()
    {


    }

    // Update is called once per frame
    void Update () {

        switch(eint)
        {
            case 1:
                epanel.SetActive(true);
                InventoryUI a = GetComponent<InventoryUI>();
                a.UpdateUI();
                break;
            case 2:
                epanel.SetActive(false);
                eint = 0;
                break;
        }
        

		
	}
}
