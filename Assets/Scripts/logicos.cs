using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicos : MonoBehaviour{
    int num1 = 10;
    int num2 = 20;
    // Start is called before the first frame update
    int num3 = 10; 

    void Start(){
        print("Operadores Lógicos entre os números " + num1.ToString() + ", " + num2.ToString() + " e " + num3.ToString());
        print("Operador E igual &&");
        print("São iguais entre si? " + (num1 == num2 && num2 == num3).ToString());
        print("São diferentes entre si? " + (num1 != num2 && num2 != num3).ToString());
        
        print("Operador OU igual ||");
        print("São iguais entre si? " + (num1 == num2 || num1 == num3).ToString());
        print("São diferentes entre si? " + (num1 != num2 || num2 != num3).ToString());

        print("Operador NOT igual !");
        print("São iguais entre si? " + (!(num1 == num2)).ToString());
        print("São diferentes entre si? " + (!(num1 == num3)).ToString());

    }

    // Update is called once per frame
    void Update(){
        
    }
}
