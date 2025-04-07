/**
 * Codigo para mantener "animado" (rotando)
 *      El skybox
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondorotativo : MonoBehaviour
{
    public float rotacion;
    
    void Start(){

    }

    void Update(){
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*rotacion);
    }

}
