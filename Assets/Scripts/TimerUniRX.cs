/*
 * 使用UniRX实现定时器功能
 * 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

public class TimerUniRX : MonoBehaviour {

	
	void Start () {
        Observable.Timer(TimeSpan.FromSeconds(5.0f))
            .Subscribe(_ =>
            {
                Debug.Log(" 定时5秒功能");
            });
    }
	
	
}
