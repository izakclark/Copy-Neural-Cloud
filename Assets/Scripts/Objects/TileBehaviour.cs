using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehaviour : MonoBehaviour
{
    public bool isSomthingStand = false;

    private void Start()
    {
        Debug.Log(isSomthingStand);
    }
    private void OnTriggerEnter(Collider other)
    {
        isSomthingStand=true;
    }
    private void OnTriggerExit(Collider other)
    {
        isSomthingStand=false;
    }
    
}
