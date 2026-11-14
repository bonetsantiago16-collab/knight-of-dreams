using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

public class Awards : MonoBehaviour

    

{
    List<string> Amenazas = new List<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        string[] Enemys = { "Goblin", "Golem", "Lobo", "No muerto" };

        Debug.Log("La marca del depurador: vence a todos los tipos de enemigos para ganar una recompensa");

        foreach (string enemy in Enemys)
        {
            Debug.Log("Enemigo por derrotar:  " + enemy);
        }

        Debug.Log("Para completar cada nivel debes acabar con la amenaza de cada zona");

        Amenazas.Add("Jefe Goblin");
        Amenazas.Add("Golem Gigante");
        Amenazas.Add("Lobo Alfa");
        Amenazas.Add("Rey Esqueleto");


        Debug.Log("Amenazas por vencer  " + Amenazas.Count);
        Debug.Log("Primer Amenaza " + Amenazas[0]);
        Debug.Log("Segundo Amenaza " + Amenazas[1]);
        Debug.Log("Tercer Amenaza " + Amenazas[2]);
        Debug.Log("Cuarto Amenaza " + Amenazas[3]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
