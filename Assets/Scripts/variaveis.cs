using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour{
    //Variáveis
    int xp = 2; //Criação e inicialização
    float coins = 10.2f; 
    bool isAlive = true;
    string userName = "NoobMaster69";

    // Start is called before the first frame update
    void Start(){
        //Este metodo (Start) só é chamado uma vez ao carregar o jogo
        xp = 10;//Sobreposição de valor ou inicialização
        print(userName + " está vivo? " + isAlive);
        print(userName + ": $ " + coins);
        print(userName + ": " + xp + "xp");

        //Conversão de Valores
        xp *= (int)coins;
        print(xp);
        userName = coins.ToString();
        
    }   
    
    /*
        Linha de Comentário com linhas
        varias linhas 
        so usar / *  * / sem espaços entre / e *  
    */

    // Update is called once per frame
    void Update(){
        //Este metodo é atualizado constantemente durante o jogo
        
    }
}
