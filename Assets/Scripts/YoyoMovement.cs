using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class YoyoMovement : MonoBehaviour
{
    public float speed;  // rounds per second
    private Transform m_Transfom;
    private bool isTweening;
   
    private void Awake()
    {
        speed = 2f;
        m_Transfom = GetComponent<Transform>();
        isTweening = false;
    }

    public void DoYoYoMove()
    {
        if (!isTweening)
        {
            float tweenTime = speed == 0 ? 0 : (1 / speed);
            isTweening = true;
            m_Transfom.DOLocalMoveY(-202, 0.5f).SetLoops(2, LoopType.Yoyo).OnComplete(()=> { isTweening = false;});
        }
    }


}
