using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matriz : MonoBehaviour{
    int[,] matriz = new int[2, 2];
    int[,] matriz1 = new int[2, 2];

    // Start is called before the first frame update
    void Start(){
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 4;

        print(matriz[1,1]);

        for(int i = 0; i < 2; i++){
            for(int j = 0; j < 2; j++){
                matriz[i, j] = i + j + 1;
                print(matriz[i, j]);
            }
        }
    }

    // Update is called once per frame
    void Update(){
        
    }
}
