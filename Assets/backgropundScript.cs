using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class backgropundScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed;
    [SerializeField]
    private Renderer bgRenderer;




    // Update is called once per frame
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime,0);
    }
}
