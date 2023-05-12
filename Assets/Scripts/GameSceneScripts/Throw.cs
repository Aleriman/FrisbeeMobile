using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Throw : MonoBehaviour
{
    //Privados
    //Camara
    private Camera cam;

    //Rigidbody de la bola.
    private Rigidbody2D ballRigidbody;

    //Correa que une la bola con el punto de sujeccion
    private SpringJoint2D ballSpringJoint;

    //Arrastrar
    private bool isDragging;
    
    //Publicas
    [Header("Objetos")]
    public GameObject ball;
    public Rigidbody2D pivot;

    [Header("SpritnJoint")]
    public float timeQuitSprintJoint;

    [Header("Timer")]
    public float timeGameOver;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;

        ballRigidbody = ball.GetComponent<Rigidbody2D>();
        ballSpringJoint = ball.GetComponent<SpringJoint2D>();

        //Aqui conectamos la bola con el pivote
        ballSpringJoint.connectedBody = pivot;
    }

    // Update is called once per frame
    void Update()
    {
        //Queremos saber si el rigidbody esta asociado
        if(ballRigidbody == null){ return; }
               

        if (!Touchscreen.current.primaryTouch.press.isPressed)
        {
            if (isDragging)
            {
                //Lanzar bola
                LanzarBola();

            }
            isDragging = false;
            return;
        }

        isDragging = true;

        //Tomamos el control de la bola
        ballRigidbody.isKinematic = true;

        Vector2 positionTouch = Touchscreen.current.primaryTouch.position.ReadValue();
        Vector3 positionWorld = cam.ScreenToWorldPoint(positionTouch);
        ballRigidbody.position = positionWorld;


        //Debug.Log(positionWorld);
    }

    private void LanzarBola()
    {
        ballRigidbody.isKinematic = false;
        ballRigidbody = null;

        //Retraso para desactivar SprintJoin
        Invoke(nameof(QuitSprintJoin), timeQuitSprintJoint);
        
    }

    private void QuitSprintJoin()
    {
        ballSpringJoint.enabled = false;
        ballSpringJoint = null;
        //Invoke(nameof(TimeOver), timeGameOver);
    }
/*
    private void TimeOver()
    {
        Debug.Log("Fin del juego");
        SceneManager.LoadScene("GameOver");
    }
*/
}
