using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrisbieController : MonoBehaviour
{
    //public GameObject objPrefab;
    [Header("Timer")]
    public float timeGameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Hola");
        if (collision.gameObject.CompareTag("Ground"))
        {
            Invoke(nameof(TimeOver), timeGameOver);
            Destroy(this.gameObject);
        }
        /*if (collision.gameObject.CompareTag("Fondo"))
        {
            
            GameObject objPrefabClone = (GameObject)Instantiate(objPrefab, transform.position, transform.rotation);
            objPrefab.transform.position = new Vector3(-4.802944f, 2.763325f, -1f);
            //Destroy(this.gameObject);

        }*/
    }

    private void TimeOver()
    {
        Debug.Log("Fin del juego");
        SceneManager.LoadScene("GameOver");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
