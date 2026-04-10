using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2IntroFunciones : MonoBehaviour
{
   public str contraseña;
//crear la funcion MensajeAccesoDenegado que escribe en consola eso
// e implementar las funcionalidades que permitan ingresar por inspector
// una cadena de caracteres y ejecutar la funcion MensajeBienvenida si
// el string coincide con TIC2026, si no, denegar.
    // Start is called before the first frame update
    void Start()
    {
      
    }

void MensajeBienvenida(){
    Debug.Log("Clash royale");
}
void MensajeAccesoAprobado(){
    Debug.Log("Contraseña Correcta");
}
void MensajeAccesoDenegado(){
    Debug.Log("Contraseña Incorrecta");
}


void ReconocerContraseña(){
    if (contraseña == TIC2026){
        Debug.Log(MensajeAccesoAprobado);
    }
    else{
        Debug.Log(MensajeAccesoDenegado);
    }
}
}
