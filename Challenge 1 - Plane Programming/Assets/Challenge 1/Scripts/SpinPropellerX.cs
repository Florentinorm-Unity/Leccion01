/*
Florentino Ramirez Balderas
GDGS2021 | 1219100383 | 17/09/2022
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float propeller = 1000;

    void Start()
    {
        
    }

    // La actualizacion se llama una sola vez por frame
    void Update()
    {
     transform.Rotate(Vector3.forward, propeller * Time.deltaTime);
   
    }
}
