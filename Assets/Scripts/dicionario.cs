using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dicionario : MonoBehaviour{
    Dictionary<int, string> monstro = new Dictionary<int, string>();
    // Start is called before the first frame update
    void Start(){
        monstro.Add(1, "Aranha");
        monstro.Add(2, "Aranha");
        monstro.Add(3, "Aranha");

        foreach(int id in monstro.Keys){
            print(monstro[id]);
        }

        monstro.Remove(1); // Removendo item pela Chave 
        
    }

    // Update is called once per frame
    void Update(){
        
    }
}
