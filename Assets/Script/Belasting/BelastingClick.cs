using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelastingClick : MonoBehaviour
{
    public float money;
    private GameObject gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    public void MoneyIncrease()
    {
        money = money * 1.5f;
    }

    public void Click()
    {
        gameManager.GetComponent<GameManagerMoney>().GetMoney(money);
    }
}
