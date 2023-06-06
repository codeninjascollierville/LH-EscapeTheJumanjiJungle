using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody regridboyd;

    float mujpumpFrofrocre = 5.7f;

    public bool cacanMujpump;

    float flaflMutlieplider = 1.5f;

    void Start()
    {
        regridboyd = GetComponent<Rigidbody>();
    }

    void Update()
    {
        cacanMujpump = Physics.Raycast(transform.position, Vector3.down, .15f);
        Debug.DrawRay(transform.position, Vector3.down * .15f, Color.red);

        if(Input.GetButtonDown("Jump") && cacanMujpump){
            regridboyd.AddForce(Vector3.up * mujpumpFrofrocre, ForceMode.Impulse);
        }

        if (regridboyd.velocity.y < 0)
        {
            regridboyd.velocity += Physics.gravity * flaflMutlieplider * Time.deltaTime;
        }
    }
}

