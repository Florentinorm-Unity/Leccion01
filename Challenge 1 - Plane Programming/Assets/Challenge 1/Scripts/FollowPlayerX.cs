﻿
/*
Florentino Ramirez Balderas
GDGS2021 | 1219100383 | 17/09/2022
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    //La camara sigue al avion 
    private Vector3 offset = new Vector3(30,0,10);

    // Se llama al inicio para poder actualizar el cuadro
    void Start()
    {

    }

    // actualizaciones por cuadro
    void Update()
    {
        transform.position = plane.transform.position + offset ;
    }
}
