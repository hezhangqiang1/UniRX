using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;


public class UseUniRx : MonoBehaviour {

	
	void Start () {
        Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.A))
            .Subscribe(_ =>
            { Debug.Log("A键按下"); }
            );
	}
	
	
	void Update () {
		
	}
}
