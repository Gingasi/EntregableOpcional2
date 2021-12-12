using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRange : MonoBehaviour
{
    public Color ColorMat;
    public Camera camera;
    void Start()
    {
        ColorMat = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        GetComponent<MeshRenderer>().material.color = ColorMat;
    }

    private void OnMouseDown()
    {
        camera.GetComponent<Camera>().backgroundColor = ColorMat;
        ColorMat = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        GetComponent<MeshRenderer>().material.color = ColorMat;
    }

    
 

   
}
