using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrCube : MonoBehaviour
{
    public static Action KillMrCube;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mort"))
        {
            KillMrCube?.Invoke();
            Destroy(gameObject);
        }
    }
    
    
}
