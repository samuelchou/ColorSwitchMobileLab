using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAttribute : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color currentColor = Color.white;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        currentColor = color;
        Debug.Log("Color set to " + color);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("Trigger with tag: " + other.tag);
        Color otherColor = ColorSet.GetColorByName(other.tag);
        // Debug.Log("Color is: " + otherColor);
        if (otherColor != currentColor) {
            Debug.Log("Not the same color!");
        }
    }
}
