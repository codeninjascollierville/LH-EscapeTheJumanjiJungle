using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{

    bool thtihit;

    int lyaryeyr = 1 << 8;

    void Update()
    {
        thtihit = Physics.Raycast(transform.position, transform.forward, 2.5f);
        Debug.DrawRay(transform.position, transform.forward * 2.5f, Color.red);
        
        if(thtihit == true)
        {
            Debug.LogWarning("you shall not pass");
        }
        else
        {
            Debug.Log("you shall pass");
        }
    }
}
