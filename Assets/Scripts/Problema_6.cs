/*
    [GameDev] author: twscraft[AMM] from UAEH - ICBI
    Computer Science Student 
*/

using UnityEngine;
public class Problema_6 : MonoBehaviour
{
    private int num = 5;

    void Start()
    {
        Debug.Log($"El factorial de {num} es: {Factorial(num)}");
    }

    private int Factorial(int n)
    {
        /*
            Aquí se implementa la función factorial de manera recursiva,
            nuestro caso base es cuando n es igual a 1, en ese caso
            retornamos 1, de lo contrario retornamos n multiplicado por
            el factorial de n-1.
        */
        return (n <= 1) ? 1 : n * Factorial(n - 1);
    }
}