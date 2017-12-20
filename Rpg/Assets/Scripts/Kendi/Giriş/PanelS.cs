using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelS : MonoBehaviour {

    public GameObject giris;
    public GameObject kayit;
    public Button buton, buton2;


	// Use this for initialization
	void Start () {

        giris.SetActive(true);
        kayit.SetActive(false);

        Button btn = buton.GetComponent<Button>();
        btn.onClick.AddListener(KayitEtkin);

        Button btn2 = buton2.GetComponent<Button>();
        btn2.onClick.AddListener(GirisEtkin);

    }

    void GirisEtkin()
    {
        giris.SetActive(true);
        kayit.SetActive(false);
    }
    void KayitEtkin()
    {
        kayit.SetActive(true);
        giris.SetActive(false);
    }

    // Update is called once per frame
    void Update () {

    }
}
