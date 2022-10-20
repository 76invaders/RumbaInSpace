using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextShaderEfects : MonoBehaviour
{
    public TextMeshProUGUI TextMesh;
    
    void FixedUpdate()
    {
        this.TextMesh.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, Random.Range(-0.045f,0.045f));
    }
}
