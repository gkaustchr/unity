using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encapsulamento : MonoBehaviour{
    Paai p;
    // Start is called before the first frame update
    void Start(){
        p = new Paai();
        print(p.Idade);
        p.Idade = 20;
        print(p.Idade);
    }

    // Update is called once per frame
    void Update(){
        
    }
}

class Paai{
    private int idade;

    public int Idade{
        get{ return idade;}
        set{ idade = value;}
    }
}