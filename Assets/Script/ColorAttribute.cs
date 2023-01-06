using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAttribute : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetRandomColor();
    }

    private void Update() {
        SetRandomColor();
    }

    void SetRandomColor()
    {
        Color[] colors = ColorSet.colors;
        int random = Random.Range(0, colors.Length);
        SetColor(colors[random]);
    }

    void SetColor(Color color)
    {
        spriteRenderer.color = color;
        Debug.Log("Color set to " + color);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger with tag: " + other.tag);
        
    }
}
