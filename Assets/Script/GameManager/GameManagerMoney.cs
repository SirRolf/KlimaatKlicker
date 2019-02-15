using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerMoney : MonoBehaviour
{
    public float money;

    public void GetMoney(float amount)
    {
        money += Mathf.Round(amount);
    }

    public bool LoseMoney(float amount)
    {
        if (money - amount >= 0)
        {
            money -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}
