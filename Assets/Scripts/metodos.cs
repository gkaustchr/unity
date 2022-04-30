using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metodos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
            Metodos metodos = new Metodos();
            metodos.soma();
            int result = metodos.subtrair();
            print(result);
            metodos.multiplicacao(2, 5);
            float div = metodos.divisao(10, 2);
            print(div);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

class Metodos: MonoBehaviour{
    public void soma(){
        int valor1= 10;
        int valor2 = 20;
        int resultado = valor1 + valor2;
        print(resultado);
    }

    public int subtrair(){
        int valor1= 10;
        int valor2 = 20;
        int resultado = valor1 - valor2;
        return(resultado);
    }

    public void multiplicacao(int a, int b){
        int resultado = a * b;
        print(resultado);
    }

    public float divisao(int a, int b){
        int resultado = a / b;
        return(resultado);
    }
}