using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour {
    public static int money;
    private int startMoney = 100;

    public void Start()
    {
        money = startMoney;
        Debug.Log("money :" + money);
    }
}
