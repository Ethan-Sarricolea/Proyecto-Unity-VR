using System.Collections;
using System.Collection.Generic;
using UnityEngine;

public class fondorotativo : MonoBehaviour
{
    public float rotacion;
    
    void Start(){

    }

    void Update(){
        RenderSettings.skybox.Setfloat("_Rotation", Time.time*rotacion);
    }

}
