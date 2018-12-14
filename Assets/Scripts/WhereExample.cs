using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;


public class WhereExample : MonoBehaviour
{


    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.A))
            .First()
            .Subscribe(_ =>
            { Debug.Log("A键按下"); }
            );
    }


}