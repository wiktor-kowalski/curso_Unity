using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI textoPuntos;

    private int puntos;
    private int puntosNecesarios;

    private void Start()
    {
        puntosNecesarios = FindObjectsOfType<Punto>().Length;
        puntos = 0;
    }

    public void AddPunto()
    {
        puntos++;
        textoPuntos.text = "Puntos: "+puntos.ToString();
        if(puntos >= puntosNecesarios)
        {
            Debug.Log("¡Has ganado!");
        }
    }

    

}
