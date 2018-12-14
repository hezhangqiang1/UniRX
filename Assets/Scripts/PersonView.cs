/**
 * 视图层： 注册Age mReactiveProeprtyExample.Age.Subscribe((age)
 *          当数据层的数据改变时视图层自动响应。
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
public class PersonView : MonoBehaviour
{
    public  Text AgeShow;
    public  ReactiveProeprtyExample mReactiveProeprtyExample;
    void Start()
    {
        //mAgeShow = transform.Find("AgeShow").GetComponent<Text>();
        //mReactiveProeprtyExample = GetComponent<ReactiveProeprtyExample>();
        Init();
    }
    /// <summary>
    /// 初始化
    /// </summary>
    void Init()
    {
        mReactiveProeprtyExample.Age.Subscribe((age) =>
        {
            Debug.Log(age);
            AgeShow.text = age.ToString();
        });
    }
}
