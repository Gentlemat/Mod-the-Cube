using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Vector3 scale = Vector3.one;
    public float rotationSpeed = 10f;
    public float colorChangeSpeed = 100f;
    private Color newColor;
    public MeshRenderer Renderer;
    private Material material;


    void Start()
    {
        transform.position = new Vector3(1, 1, 1);
        transform.localScale = scale;
        material = Renderer.material;

        material.color = RandomColor();
        newColor = RandomColor();
    }
    
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0.0f, 0.0f);
        material.color = Color.Lerp(material.color, newColor, colorChangeSpeed * Time.deltaTime);
    }

    private Color RandomColor()
    {
        float randomRed = Random.Range(0, 1f);
        float randomGreen = Random.Range(0, 1f);
        float randomBlue = Random.Range(0, 1f);

        return new Color(randomRed, randomGreen, randomBlue);
    }
}
