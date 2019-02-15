using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyObjectBuy : MonoBehaviour
{
    public float price;
    public bool Doubles;

    private GameObject gameManager;
    private GameObject belastingKnop;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        belastingKnop = GameObject.Find("Belasting");
    }

    public void Buy()
    {
        if (gameManager.GetComponent<GameManagerMoney>().LoseMoney(price))
        {
            price = Mathf.Round(price * 1.5f);
            if (Doubles)
            {
                belastingKnop.GetComponent<BelastingClick>().MoneyIncrease();
            }
        }
    }
}
