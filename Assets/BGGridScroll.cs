using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGGridScroll : MonoBehaviour
{
    public float scroll_Speed = 0.1f;
    private MeshRenderer mesh_Renderer;
    private float x_Scroll;
    

    void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
        Time.timeScale = 1F;
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        x_Scroll = Time.time * scroll_Speed;
        Vector2 offest = new Vector2(0f, x_Scroll);
        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offest);
    }
}
