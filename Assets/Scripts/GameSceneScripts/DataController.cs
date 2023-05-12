using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private int puntuacion;

    public int Puntuacion { get => puntuacion; set => puntuacion = value; }
    // Start is called before the first frame update
    private void Awake()
    {
        int numInstancias = FindObjectsOfType<DataController>().Length;

        if(numInstancias != 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
