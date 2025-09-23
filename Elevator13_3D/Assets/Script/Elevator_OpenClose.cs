using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_OpenClose : MonoBehaviour
{
    [SerializeField] Animator doorLeft;
    [SerializeField] Animator doorRight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            doorLeft.SetTrigger("open");
            //doorRight.SetTrigger("open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            doorLeft.SetTrigger("close");
        }
    }
}
