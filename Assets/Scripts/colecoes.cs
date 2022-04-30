using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colecoes : MonoBehaviour{
    List<int> lista = new List<int>();
    List<int> lista1 = new List<int>();
    // Start is called before the first frame update
    void Start(){
        lista.Add(100);
        lista.Add(200);
        lista.Add(300);
        print(lista[1]);
        lista.Remove(100); //Remove o valor e o index
        print(lista[1]);
        print(lista.IndexOf(300)); //Pega o Index

        //Criando e Mostrando Lista Automaticamente
        for(int i = 0; i < 5; i++){
            lista1.Add(i * 2);
        }

        foreach(int valor in lista1){
            print(valor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
