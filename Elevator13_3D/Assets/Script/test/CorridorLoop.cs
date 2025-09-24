using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorLoop : MonoBehaviour
{
    public Transform teleportPoint;
    public bool isForwardTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleportPoint.position;
        }
    }
}
