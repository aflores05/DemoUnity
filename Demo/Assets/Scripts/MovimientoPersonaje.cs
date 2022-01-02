using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad;
    public float sensibilidadDelRaton;

    // Update is called once per frame
    void Update()
    {
        //Adelante
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, velocidad*Time.deltaTime);
        }

        //Izquierda
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-velocidad * Time.deltaTime, 0, 0);
        }

        //Atrás
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -velocidad * Time.deltaTime);
        }

        //Derecha
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }

        transform.Rotate(0, Input.GetAxis("Mouse X")*sensibilidadDelRaton*Time.deltaTime, 0);
    }
}
