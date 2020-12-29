using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class GameController : MonoBehaviour
{
    public GameObject ButtonKuda;
    public GameObject ButtonKucing;
    public GameObject ButtonAnjing;
    public GameObject ButtonBebek;
    public GameObject Panel;
    public GameObject ButtonSembunyi;

    public Text Title;
    public Text Content;

    public void showButtonKuda(){
        ButtonKuda.SetActive(true);
    }

    public void showButtonKucing(){
        ButtonKucing.SetActive(true);
    }

    public void showButtonAnjing(){
        ButtonAnjing.SetActive(true);
    }
    
    public void showButtonBebek(){
        ButtonBebek.SetActive(true);
    }

    public void hideButtonKuda(){
		ButtonKuda.SetActive(false);
        hideButton();
	}

    public void hideButtonKucing(){
        ButtonKucing.SetActive(false);
        hideButton();
	}

    public void hideButtonAnjing(){
        ButtonAnjing.SetActive(false);
        hideButton();
	}

    public void hideButtonBebek(){
        ButtonBebek.SetActive(false);
        hideButton();
	}

	public void hideButton(){
        Panel.SetActive(false);
        ButtonSembunyi.SetActive(false);
	}

    public void showKucing(){
        Title.text="KUCING";
        Content.text = "Kucing adalah sejenis mamalia karnivora dari keluarga felidae.";
        showPanel();
	}

    public void showAnjing(){
		Title.text="ANJING";
        Content.text = "Anjing adalah mamalia yang berasal dari spesies Canis lupus familiaris.";
        showPanel();
	}

    public void showKuda(){
		Title.text="KUDA";
        Content.text = "Kuda adalah salah satu dari sepuluh spesies modern mamalia dari genus Equus. Kuda dapat ditunggani oleh manusia dengan menggunakan sadel.";
        showPanel();
	}

    public void showBebek(){
		Title.text="BEBEK";
        Content.text = "Bebek adalah nama umum untuk beberapa spesies burung dalam faimili Anatidae. Bebek umumnya dapat ditemukan pada perairan air tawar maupun air laut.";
        showPanel();
	}

    public void showPanel(){
        Panel.SetActive(true);
        ButtonSembunyi.SetActive(true);
	}
}
