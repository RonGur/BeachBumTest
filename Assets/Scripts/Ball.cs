using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(YoyoMovement))]
[RequireComponent(typeof(ColorShuffle))]
public class Ball : MonoBehaviour
{
    private YoyoMovement m_YoyoMovement;
    private ColorShuffle m_ColorShuffle;

    private void Awake()
    {
        GetRequiredComponent();
    }

    public void OnClickGameButton()
    {
        if (m_YoyoMovement)
        {
            m_YoyoMovement.DoYoYoMove();
        }

        if (m_ColorShuffle)
        {
            m_ColorShuffle.ChangeRandomColor();
        }
    }
    private void GetRequiredComponent()
    {
        if (TryGetComponent(out YoyoMovement yoyoMovement))
        {
            m_YoyoMovement = yoyoMovement;
        }
        else
        {
            Debug.LogError("No YoyoMovement component in ball");
        }

        if (TryGetComponent(out ColorShuffle colorShuffle))
        {
            m_ColorShuffle = colorShuffle;
        }
        else
        {
            Debug.LogError("No ColorShuffle component in ball");
        }
    }


}
