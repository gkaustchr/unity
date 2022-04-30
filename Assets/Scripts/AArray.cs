using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AArray : MonoBehaviour{
    //Formas diferentes de declarar Arrays
    int[] array = {1, 2, 3, 4}; 
    int[] array1 = new int[4]{1, 2, 3, 4};
    int[] array2 = new int[4];
    int[] array3 = new int[10];

    // Start is called before the first frame update
    void Start(){
        print(array[0]);
        print(array1[1]);
        array2[2] = 3;
        print(array2[2]);     

        for(int i = 0; i <= 9; i++){
            array3[i] = i + 1;
            print(array3[i]);
        }
    }

    // Update is called once per frame
    void Update(){
        
    }
}
