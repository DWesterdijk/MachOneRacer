using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFloat : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<VehicleFloat>())
        {
            other.GetComponent<VehicleFloat>().enabled = true;
        }
    }
}
