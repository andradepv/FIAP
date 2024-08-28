using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Cap7 : MonoBehaviour
{
    string Nome;
    int Vida;
    string[] Armas = new string[4];
    int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        print(Armas);
        if(Nome == null || Armas.Length != 4 || Armas[0] == null || Armas[1] == null || Armas[2] == null || Armas[3] == null)
        {
            print("Todos os atributos devem ser preenchidos");
        }
        
        
        else {
            ChecagemVida(Vida);

            foreach (string arma in Armas)
            {
                print("Arma " + i + " : " + arma);
                i++;
            }
        }
        
    }

    string ChecagemVida(int Vida)
    {
        if (Vida > 0)
        {
            return "Em jogo";
        }

        else
        {
            return "Fim de jogo";
        }

    }
}

