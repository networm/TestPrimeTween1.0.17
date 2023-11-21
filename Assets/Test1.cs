using PrimeTween;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    private int _frame;

    void Start()
    {
        var seq = Sequence.Create();
        seq.Group(Tween.LocalPositionX(transform, 0.6f, 0.1f));
        seq.SetCycles(10);
    }

    void Update()
    {
        _frame++;
        if (_frame == 120)
        {
            Tween.StopAll(transform);
        }
    }
}
