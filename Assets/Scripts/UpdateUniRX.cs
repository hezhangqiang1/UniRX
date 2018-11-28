/*
 * UniRx模仿update
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class UpdateUniRX : MonoBehaviour {

	
	void Start () {
        Observable.EveryUpdate()
            .Subscribe(_ =>
            {
                if(Input.GetMouseButtonDown(0))
                {
                    Debug.Log("鼠标左键按下");
                }
            });
	}
	
	
}
