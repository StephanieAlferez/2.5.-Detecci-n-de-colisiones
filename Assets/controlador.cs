using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{
    public GameObject jugador;

    public float velocidadMovimiento;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindObjectOfType<jugador0>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Input.GetAxis("Horizontal") * velocidadMovimiento * Time.deltaTime);  
    }
}
