using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condicionais : MonoBehaviour{
    int coins = 100;
    int espaçoBolsa = 10;

    // Start is called before the first frame update
    void Start(){
        print("Coins: $ " + coins);
        print("Mochila: "  + espaçoBolsa + " und");
        print("Tentar comprar mais espaço para a Mochila. \n Mais 5 espaços custa 100$");
        if(coins > 100){
            espaçoBolsa += 5;
            coins -= 100;
            print("Bom trabalho! Você está indo bem!");
        }else if(coins == 100){
            espaçoBolsa += 5;
            coins -= 100;
            print("Deu sorte! Quantidade suficiente para compra!");
        }else{
            print("Você não tem dinheiro suficiente! \n Volte ao trabalho, vagabundo!");
        }
        print("Coins: $ " + coins);
        print("Mochila: "  + espaçoBolsa + " und");
    }

    // Update is called once per frame
    void Update(){
        
    }
}
