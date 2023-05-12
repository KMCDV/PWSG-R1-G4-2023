using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveWithDotween : MonoBehaviour
{
    public GameEvent gameEvent;
    void Start()
    {
        transform.DOMoveY(10f, 1f).SetRelative(true).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutElastic);
        transform.DORotate(new Vector3(0, 0, 360), 1f, RotateMode.LocalAxisAdd).SetLoops(-1);
        transform.DOScale(1.05f, 1f).SetRelative(true).SetLoops(-1, LoopType.Yoyo);


        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        Color currentColor = meshRenderer.material.color;
        currentColor.a = .2f;
        meshRenderer.material.DOColor(currentColor, .5f).SetLoops(6, LoopType.Yoyo);
    }

    private void OnMouseDown()
    {
        gameEvent.Raise();
    }
}
