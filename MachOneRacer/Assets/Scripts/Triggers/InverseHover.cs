using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InverseHover : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<VehicleFloat>())
        {
            if (other.GetComponent<VehicleFloat>()._hoverForce == other.GetComponent<VehicleFloat>()._hoverForce)
            {
                other.GetComponent<VehicleFloat>()._hoverForce = -other.GetComponent<VehicleFloat>()._hoverForce;
            }
        }
    }
}
