using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIDebugText : MonoBehaviour
{
    public Text debugText;
    public Text lapText;

    void Start()
    {
        debugText.text = "Checkpoint Counter: " + this.GetComponent<CheckpointCounter>().checkPointCounter;
        lapText.text = "Lap count: " + this.GetComponent<CheckpointCounter>().lapCount + " / " + this.GetComponent<CheckpointCounter>().maxLaps;
    }

    void Update()
    {
        debugText.text = "Checkpoint Counter: " + this.GetComponent<CheckpointCounter>().checkPointCounter;
        lapText.text = "Lap count: " + this.GetComponent<CheckpointCounter>().lapCount + " / " + this.GetComponent<CheckpointCounter>().maxLaps;
    }
}
