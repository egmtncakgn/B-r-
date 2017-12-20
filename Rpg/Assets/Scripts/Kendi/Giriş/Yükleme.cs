using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yükleme : MonoBehaviour {

    public Text yuzde, ipucu;
    public float yuzde_;
    public GameObject bar, ekran, aEkran;
    public int ipucuSay;

	// Use this for initialization
	void Start () {

        ipucuSay = Random.Range(1,5);
        ekran.SetActive(true);
        aEkran.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {

        if (yuzde_ < 100)
        {
            yuzde_ += Time.deltaTime * 5;
        }

        if (yuzde_ >= 100)
        {
            yuzde_ = 100;
            ekran.SetActive(false);
            aEkran.SetActive(true);
        }

        yuzde.text = "" + (int)yuzde_ + "%";
        bar.transform.localScale = new Vector3(yuzde_ / 100, 1, 1);

        if (ipucuSay == 1)
        {
            ipucu.text = "İpucu: Börü MMORPG Sadece 2 Kişilik Bir Ekibin Ürünüdür.";
        }
        if (ipucuSay == 2)
        {
            ipucu.text = "İpucu: Ne Kadar İskelet Kesersen O Kadar Altın Alırsın.";
        }
        if (ipucuSay == 3)
        {
            ipucu.text = "İpucu: Börü Oyunnun Son Ve En Güçlü Boss'unun İsmidir.";
        }
        if (ipucuSay == 4)
        {
            ipucu.text = "İpucu: Börü MMORPG Erken Erişime Sunuldu!";
        }
        if (ipucuSay == 5)
        {
            ipucu.text = "İpucu: Ödül Kazanmak İçin Görevleri Tamamla.";
        }
    }

    
}
