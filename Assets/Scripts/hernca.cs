using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hernca : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
}

class Pai{
    public int idade;
}

class Filho: Pai{

    public int pegaIdade(){
        return base.idade;
    }
}