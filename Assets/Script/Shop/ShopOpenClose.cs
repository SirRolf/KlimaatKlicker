using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOpenClose : MonoBehaviour
{
    public bool isActive = false;

    public void SwitchShop()
    {
        isActive = !isActive;
    }

    void Update()
    {
        float step = 750 * Time.deltaTime;
        if (isActive == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(1670, 540, 0), step);
        }
        else if (isActive == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(2170, 540, 0), step);
        }
    }
}
