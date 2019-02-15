using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public Text Cash;

    GameManagerMoney GMM;

    // Start is called before the first frame update
    void Start()
    {
        GMM = gameObject.GetComponent<GameManagerMoney>();
    }

    // Update is called once per frame
    void Update()
    {
        Cash.text = "Money: " + GMM.money;
    }
}