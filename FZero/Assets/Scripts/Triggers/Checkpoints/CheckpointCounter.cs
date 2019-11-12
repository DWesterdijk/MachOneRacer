using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCounter : MonoBehaviour
{
    public int checkPointCounter;
    public int lapCount;
    public int maxLaps;

    void Awake()
    {
        checkPointCounter = 0;
        lapCount = 1;
    }
}
