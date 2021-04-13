using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform theDest;

    void Update()
    {
        PickUpOnE();
    }

    void PickUpOnE()
    {
        //Input.GetKey(KeyCode) bestämmer vilken knapp som blir uppplocknings knappen.
        if (Input.GetKey(KeyCode.E))
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = theDest.position;
            /*Destination är namnet på platsen där objektet kommer att hamna.
             Går alltså att byta namnet till ett som matchar platsen objektet ska hamna på. */
            this.transform.parent = GameObject.Find("Destination").transform;
        }
    }
}
