using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReDoGame : MonoBehaviour
{
    public GameObject objPrefab;
    public Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Instantiate(objPrefab, pos.position, Quaternion.identity);
            Debug.Log("Choca");
        }
    }
}
