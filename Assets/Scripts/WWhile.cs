using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
public class WWhile : MonoBehaviour{
    
    int userLife = 100;
    // Start is called before the first frame update
    void Start(){
        int dotToUse = Random.Range(0, 20);
        print("Você está Vivo!");
        while ( userLife > 0){
            print("Aranha atacou");        
            if (dotToUse % 2 == 0){
                print("Você foi acertado - 5 de vida");
                userLife -= 5;
                print("Life: " + userLife);
            }
        }
        print("Morto ;(");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
