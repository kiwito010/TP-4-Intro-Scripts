using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ0NegativooPositivo : MonoBehaviour
{
  public int num1;
    // Start is called before the first frame update
    void Start()
    {
        if(num1>0){
            Debug.Log("el numero es mayor a 0");
        }
        else if(num1<0){
            Debug.Log("el numero es menor a 0");
        }
        else{
            Debug.Log("el numero es igual a 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
