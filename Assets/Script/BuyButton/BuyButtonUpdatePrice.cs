using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButtonUpdatePrice : MonoBehaviour
{
    void Update()
    {
        GetComponentInChildren<Text>().text = transform.parent.gameObject.GetComponent<BuyObjectBuy>().price.ToString();
    }
}
