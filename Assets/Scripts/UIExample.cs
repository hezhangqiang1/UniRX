/***
 * 脚本功能：UniRX与UGUI的交互
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using UniRx.Triggers; //与图片等其他UI交互的命名空间
public class UIExample : MonoBehaviour {


	void Start () {
        var button = transform.Find("Button").GetComponent<Button>();
        button.OnClickAsObservable()
            .Subscribe(_ => Debug.Log("buttonCliick"));

        var image = transform.Find("Image").GetComponent<Graphic>();
        image.OnBeginDragAsObservable().Subscribe(_ => Debug.Log("图片开始拖拽"));
        image.OnDragAsObservable().Subscribe(_ => Debug.Log("图片拖拽中"));
        image.OnEndDragAsObservable().Subscribe(_ => Debug.Log("图片结束拖拽"));

    }
	
	
	
}
