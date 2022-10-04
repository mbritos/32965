using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuroMovimiento : MonoBehaviour
{
    // Declaro las variables a modificar desde el editor

    public Vector3 escala;
    public Vector3 direccion;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = escala;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccion * Time.deltaTime * velocidad);
    }
}
