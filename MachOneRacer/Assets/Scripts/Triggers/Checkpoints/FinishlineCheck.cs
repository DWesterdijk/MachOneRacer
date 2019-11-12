using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishlineCheck : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other);
        if (other.GetComponent<CheckpointCounter>().checkPointCounter >= 4)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Debug.Log("DOMINANCE!!");
                transform.GetChild(i).gameObject.SetActive(true);
            }

            other.GetComponent<CheckpointCounter>().checkPointCounter = 0;
            other.GetComponent<CheckpointCounter>().lapCount++;
            if (other.GetComponent<CheckpointCounter>().lapCount == other.GetComponent<CheckpointCounter>().maxLaps)
            {
                Debug.Log("Game over");
                //End game;
            }
        }
        else
        {
            //do nothing
        }
    }
}
