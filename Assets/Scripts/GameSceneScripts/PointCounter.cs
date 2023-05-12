using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    //Atributos
    private int cont = 0;
    private DataController datController;

    public GameObject objPrefab;
    public Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        datController = GameObject.Find("GameData").GetComponent<DataController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Frisbee"))
        {
            Destroy(collision.gameObject);
            cont++;
            datController.Puntuacion = cont;
            Instantiate(objPrefab, pos.position, Quaternion.identity);
            Debug.Log(cont);
        }
    }
}
