using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSwitch : MonoBehaviour{

    int typeCity = 5;

    // Start is called before the first frame update
    void Start(){
        print("Tipo de Cidades\n 1 - Aqui não há batalhas; 2 - Cuidado com os monstros; 3 - Cuidado com Outros Usuários; 4 - Aqui Fazemos trocas de itens; 5 - Corra!");
        switch(typeCity){
            case 1:
                print("Você está dentro da cidade, não precisa ter medo, guarde essa ARMA!");
                break;
            case 2: 
                print("Você não está mais no centro da cidade, cuidado com os monstros, pegue essa ARMA!");
                break;
            case 3:
                print("Você não está mais no centro da cidade, cuidado com os monstros e com outros USUÁRIOS, pegue essa ARMA!");
                break;
            case 4:
                print("Você está dentro da cidade,abra su baú e guarde essa ARMA!");
                break;
            case 5:
                print("Você está dentro da caverna! CORRA! CORRA! CORRA!");
                break;
            default:
                print("OPS! Não faço ideia de onde vc está, tome cuidado!");
                break;
        }
    }

    // Update is called once per frame
    void Update(){
        
    }
}
