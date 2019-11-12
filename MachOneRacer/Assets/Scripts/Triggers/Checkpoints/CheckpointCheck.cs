using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CheckpointCounter>())
        {
            Debug.Log("Other found");
            other.GetComponent<CheckpointCounter>().checkPointCounter++;

            this.gameObject.SetActive(false);
        }
    }
}
