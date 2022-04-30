using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scopo : MonoBehaviour{
    int valor = 0; // Variavel global todos os metodos podem acessar
    // Start is called before the first frame update
    void Start(){
        print(valor);
        int teste = 1; // Variavel local, so este metodo pode acessar
        print(teste);
    }

    // Update is called once per frame
    void Update(){
        print(valor);
        int teste = 1; // Variavel local, so este metodo pode acessar
        print(teste);
    }
}
