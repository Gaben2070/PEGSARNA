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
        //Input.GetKey(KeyCode) best�mmer vilken knapp som blir uppplocknings knappen.
        if (Input.GetKey(KeyCode.E))
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = theDest.position;
            /*Destination �r namnet p� platsen d�r objektet kommer att hamna.
             G�r allts� att byta namnet till ett som matchar platsen objektet ska hamna p�. */
            this.transform.parent = GameObject.Find("Destination").transform;
        }
    }
}
