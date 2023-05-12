using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Text mensajeResultado;
    private DataController datosPartida;
    // Start is called before the first frame update
    void Start()
    {
        datosPartida = GameObject.Find("GameData").GetComponent<DataController>();
        string mensajeFinal = datosPartida.Puntuacion.ToString();

        mensajeResultado.text = mensajeFinal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
