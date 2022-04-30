using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enumeradores : MonoBehaviour{
    enum AI {atacar, correr, patrulhar}
    // Start is called before the first frame update
    void Start(){
        AI vilaoFase1 = AI.atacar;
        AI vilaoFase2 = AI.patrulhar;

        print(vilaoFase1);

        int index = (int)vilaoFase2;
        print(index);
    }

    // Update is called once per frame
    void Update(){
        
    }
}
