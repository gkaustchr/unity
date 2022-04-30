using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ternarios : MonoBehaviour
{
   int coins = 100;
    int espaçoBolsa = 10;

    // Start is called before the first frame update
    void Start(){
        print("Coins: $ " + coins);
        print("Mochila: "  + espaçoBolsa + " und");
        print("Tentar comprar mais espaço para a Mochila. \n Mais 5 espaços custa 100$");
        
        string result = coins >= 100 ? "Compra Efetuada com Sucesso" : "Você não tem dinheiro suficiente. Volte ao trablho!";
        print(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
