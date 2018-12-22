using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ATH : MonoBehaviour {

    public TextMeshProUGUI MoneyPlayer;
    public TextMeshProUGUI Towerselect;

    void Start () {

    }
	

	void Update () {
        MoneyPlayer.text = "Money : " + PlayerStat.money.ToString();
        Towerselect.text = Shop.Towerselect;
	}
}
