/*
    [GameDev] author: twscraft[AMM] from UAEH - ICBI
    Computer Science Student 
*/

using UnityEngine;

public class Problema_4 : MonoBehaviour
{
    //Variable privada
    private bool condicion;

    //Variables publicas
    public int val1 = 5;
    public int val2 = 4;

    void Start()
    {
        //Si la suma de val1 y val2 es par, entonces condicion es true
        if ((val1 + val2) % 2 == 0)
        {
            condicion = true;
            Debug.Log($"Valor de la condicional: {condicion}");
        }
        //Si la suma de val1 y val2 es impar, entonces condicion se mantiene en false
        else
        {
            Debug.Log($"Valor de la condicional: {condicion}");
        }

    }
}