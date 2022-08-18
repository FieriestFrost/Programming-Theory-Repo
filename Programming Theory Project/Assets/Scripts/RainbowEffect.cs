using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowEffect : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    [SerializeField] private float rainbowSpeed;
    private float hue;
    private float sat;
    private float bri;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RainbowColorChange();
    }

    void RainbowColorChange()
    {
        Color.RGBToHSV(meshRenderer.material.color, out hue, out sat, out bri);
        hue += rainbowSpeed / 10000;
        if (hue >= 1)
        {
            hue = 0;
        }
        sat = 0.5f;
        bri = 0.5f;
        meshRenderer.material.color = Color.HSVToRGB(hue, sat, bri);
    }
}
