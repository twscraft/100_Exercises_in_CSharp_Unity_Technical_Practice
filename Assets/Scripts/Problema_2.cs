/*
    [GameDev] author: twscraft[AMM] from UAEH - ICBI
    Computer Science Student 
*/

using UnityEngine;

public class Problema_2 : MonoBehaviour
{
    private float var1 = 6.0f;
    private float var2 = 4.0f;
    void Start()
    {
        Debug.Log("Operaciones de suma, resta, multiplicación y división");
        Debug.Log("Valor de var1: " + var1);
        Debug.Log("Valor de var2: " + var2);
        Debug.Log("-------------------------");
        Debug.Log("Suma: " + (var1 + var2));
        Debug.Log("Resta: " + (var1 - var2));
        Debug.Log("Multiplicación: " + (var1 * var2));
        Debug.Log("División: " + (var1 / var2));
    }
}