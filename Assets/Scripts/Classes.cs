using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour{
    //Criando Objeto
    Aranha fraca;

    // Start is called before the first frame update
    void Start(){
        //Instanciando
        fraca = new Aranha();
        fraca.nome = "Aranha";
        fraca.forca = 10;
        fraca.id = 101;
        fraca.level = 2;
        fraca.velocidade = 10f;
        fraca.atacar("Vai porra");
        print(fraca.id);

    }

    // Update is called once per frame
    void Update(){
        
    }
}

class Monstro{
    //caracteristicas == atributos
    public string nome;
    public float velocidade;
    public int forca;
    public int level;
    public int id;


    //ações == metodos
    public void acessar(){

    }
}

//Herança
class Aranha: Monstro{
    public void atacar(string texto){
        //print(texto);
    }
}