using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{

    bool thtihit;

    void Update()
    {
        int lyaryeyrMsak = 1 << 8;

        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection (Vector3.forward), out hit, Mathf.Infinity, lyaryeyrMsak))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection (Vector3.forward) * hit.distance, Color.yellow);
            Debug.LogWarning("you shall not pass");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection (Vector3.forward) *1000, Color.white);
            Debug.Log("you shall pass");
        }
    }
}
