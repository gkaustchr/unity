using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operadores : MonoBehaviour{
    // Start is called before the first frame update
    int num1, num2, num3;
    float resultado;
    void Start(){
        num1 = 10; 
        num2 = 6;
        num3 = 15;

        print("Operações Simples: \n Soma - Subtração - Multiplicação - Divisão");
        resultado = num1 + num2;
        print(resultado);

        resultado = num3 - num1;
        print(resultado);

        resultado = num1 * num2 * num3;
        print(resultado);

        resultado = (float) num3/num2;
        print(resultado);
        

        // Resto da divisão
        print("Resto da Divisão");
        resultado = (float) num3 % num1;
        print(resultado);

        //Incremento e decremento
        print("Incremento e Decremento");
        num1++;
        print(num1);

        num3--;
        print(num3);


        //Operadores Reduzidos
        print("Operadores Reduzidos");
        num1 += 20;
        print(num1);

        num2 -= 5;
        print(num2);

        num3 += num1;
        print(num3);

        num3 *= num2;
        print(num3);

        num1 /= 2;
        print(num1);

        num3 /= num1;
        print(num3);
    }

    // Update is called once per frame
    void Update(){
        
    }
}
