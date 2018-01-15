using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class DoTweenTest : MonoBehaviour 
{
    private Tweener ter;

    private void Start () 
	{
        
        Sequence seq = DOTween.Sequence();
        ter = transform.DOMoveX(20, 2f);
        seq.Append(ter);
        seq.Append(transform.DORotate(new Vector3(0, 180, 0), 2));
        seq.SetLoops(-1);
        seq.Play();

        transform.DOMove(new Vector3(5, 2, 2), 1).SetEase(Ease.OutQuint).SetLoops(1).OnComplete(myFunction);

        
    }

    private void myFunction()
    {
        transform.GetComponent<Renderer>().material.DOColor(Color.red, 2);
    }

    private void Update () 
	{
		
	}
}
