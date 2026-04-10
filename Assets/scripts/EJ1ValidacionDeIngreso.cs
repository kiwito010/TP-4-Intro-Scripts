using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ1ValidacionDeIngreso : MonoBehaviour
{
    public int año;
    //Permitir el ingreso por inspector de un numero entero
    //si el numero es mayor a 1900 y menor que 2027
    //escribir en consola gracias, en caso contrario escribir caso no valido
    // Start is called before the first frame update
    void Start()
    {
        if (año<2027 && año>1900){
        Debug.Log ("Gracias");
    }
    else{
        Debug.Log ("no valido");
    }}


    // Update is called once per frame
    void Update()
    {
        
    }
}
