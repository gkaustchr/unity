using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polimorfismo : MonoBehaviour{
    Leão leao;
    Gato gato;
    // Start is called before the first frame update
    void Start(){
        leao = new Leão();
        gato = new Gato();

        leao.comer();
        gato.comer();
    }

    // Update is called once per frame
    void Update(){
        
    }
}

class Animal:MonoBehaviour{
    public virtual void comer(){
        print("Está Comendo");
    }
}

class Leão:Animal{
    public override void comer(){
        print("Leão Está Comendo");
    }
}

class Gato:Animal{
    public override void comer(){
        print("Gato Está Comendo");
    }
}