using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehaviour : MonoBehaviour
{
    public static bool isItStandHere = false;
    private void OnCollisionEnter(Collision collision)
    {
        isItStandHere = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isItStandHere = false;
    }
}
