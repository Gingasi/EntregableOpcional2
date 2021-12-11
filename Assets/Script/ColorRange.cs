using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRange : MonoBehaviour
{
    public Color ColorMat;

    public Color RandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
    private void OnMouseDown()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ColorMat = new Color(1, 0, 0, 1);
            GetComponent<MeshRenderer>().material.color = ColorMat;
        }
        
    }
    
}
