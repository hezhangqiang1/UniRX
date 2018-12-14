/**
 * UniRXd的特色：响应式编程，可以声明ReactiveProperty 然后当声明的值改变时会通知
 *               所有注册的事件作出相应的改变。
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ReactiveProeprtyExample : MonoBehaviour {

    public ReactiveProperty<int> Age = new ReactiveProperty<int>() ;

	void Start () {
        Age.Subscribe(age =>
        {
            Debug.Log("年龄值改变");
        });
        Age.Value = 0;
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Age.Value += 10;
        }
    }
	
}


