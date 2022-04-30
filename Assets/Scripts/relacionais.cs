using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relacionais : MonoBehaviour{
    int num1 = 10;
    int num2 = 20;
    // Start is called before the first frame update
    void Start(){
        print("Operadores Relacionais");
        print("É igual? " + (num1 == num2).ToString());
        print("É diferente? " + (num1 != num2).ToString());
        print("É maior? " + (num1 > num2).ToString());
        print("É menor? " + (num1 < num2).ToString());
        print("É maior ou igual? " + (num1 >= num2).ToString());
        print("É menor ou igual? " + (num1 <= num2).ToString());
    }

    // Update is called once per frame
    void Update(){
        
    }
}
