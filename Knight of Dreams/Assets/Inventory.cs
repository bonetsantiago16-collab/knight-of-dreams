using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    List<string> Inventario = new List<string>();
    void Start()
    {
        Inventario.Add("Llave");
        Inventario.Add("Pocion de curacion");
        Inventario.Add("Arco");
        Inventario.Add("Espada");

        Debug.Log("Numero de objetos adquiridos  " + Inventario.Count);
        Debug.Log("Primer objeto " + Inventario[0]);
        Debug.Log("Segundo objeto " + Inventario[1]);
        Debug.Log("Tercer objeto " + Inventario[2]);
        Debug.Log("Cuarto objeto " + Inventario[3]);

    }

    
    void Update()
    {
        
    }
}
