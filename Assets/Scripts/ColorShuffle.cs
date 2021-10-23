using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorShuffle : MonoBehaviour
{
    private Image m_Image;
    private void Awake()
    {
        m_Image = GetComponent<Image>();
    }

    public void ChangeRandomColor()
    {
        m_Image.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.3f, 1f); ;
    }
}
