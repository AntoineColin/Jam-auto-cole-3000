using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propulsion : MonoBehaviour
{
    public float trust;

    Rigidbody rigi;

    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigi.AddForce(transform.forward * 100 * trust);
        }
        if (Input.GetButtonDown("Horizontal"))
        {
            rigi.AddTorque(transform.forward * 100 * -Input.GetAxis("Horizontal"));
        }
        if (Input.GetButtonDown("Vertical"))
        {
            rigi.AddTorque(transform.right * 100 * -Input.GetAxis("Vertical"));
        }
    }
}
