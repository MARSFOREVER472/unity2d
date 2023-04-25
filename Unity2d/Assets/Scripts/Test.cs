using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    #region CLASS_VARIABLES

    public int entero;
    public float flotante;
    public string texto;

    public int prueba = 10;

    #endregion

    private void Awake()
    {
        DebugEntero();
    }

    private void Start()
    {
        DebugFlotante();
    }

    private void Update()
    {
        DebugTexto();
    }

    #region CLASS_METHODS

    public void DebugEntero()
    {
        Debug.Log("El valor del entero es: " + entero);
    }

    public void DebugFlotante()
    {
        Debug.Log("El valor decimal es: " + flotante);
    }

    public void DebugTexto()
    {
        Debug.Log("El valor del texto es: " + texto);
    }

    #endregion
}
