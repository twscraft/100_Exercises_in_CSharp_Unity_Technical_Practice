/*
    [GameDev] author: twscraft[AMM] from UAEH - ICBI
    Computer Science Student 
*/

using System;
using UnityEngine;

public class Problema_5 : MonoBehaviour
{
    void Start()
    {   
        Debug.Log((DateTime.Now.DayOfWeek == DayOfWeek.Thursday)? "Hoy es jueves" : "Hoy no es jueves");
    }
}