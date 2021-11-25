using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Timer : MonoBehaviour
{
    public float targetTime;
    public static Action Minute;
    public static Action ThreeMinute;
    public static Action ClaquetteSound;
    public static Action ClubSound;
    public void Update(){
 
        targetTime += Time.deltaTime;
 
        if (targetTime >= 60.0f)
        {
            Minute?.Invoke();
        }
        
        if (targetTime >= 120.0f)
        {
            ThreeMinute?.Invoke();
        }
 
    }

    public void Claquette()
    {
        ClaquetteSound?.Invoke();
    }

    public void Club()
    {
        ClubSound?.Invoke();
    }

}

