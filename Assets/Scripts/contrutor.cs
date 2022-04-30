using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contrutor : MonoBehaviour{
    Metodos1 obj;

    // Start is called before the first frame update
    void Start(){
        obj = new Metodos1(10, 27);
        print(obj.valor1);
        print(obj.valor2);

        int result =  Metodos1.testando(2, 5);
        print(result);
    }

    // Update is called once per frame
    void Update(){
        
    }
}

class Metodos1{
    public int valor1;
    public int valor2;

    public Metodos1(int valor1, int valor2){
        this.valor1 = valor1;
        this.valor2 = valor2;
    }

    public static int testando(int val1, int val2){
        int result = val1 + val2;
        return result ;
    }

}
