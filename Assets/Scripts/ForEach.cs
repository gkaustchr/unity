using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEach : MonoBehaviour{
    string[] inimigos;
    // Start is called before the first frame update
    void Start(){
        inimigos = new string[4];
        inimigos[0] = "Caveira";
        inimigos[1] = "Aranha";
        inimigos[2] = "Lobo";
        inimigos[3] = "Mark";

        foreach(string nome in inimigos){
            print(nome);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
