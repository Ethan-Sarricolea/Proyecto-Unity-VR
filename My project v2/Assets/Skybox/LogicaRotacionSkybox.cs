using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class LogicaRotacionSkybox : MonoBehaviour
{

    public float velocidadRotacion;

    // Antes de la primer llamada update para el frame
    void Start()
    {
        // code
    }

    // Actualiza por cada frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * velocidadRotacion);
    }
}
