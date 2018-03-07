using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//じゃんけんゲームの流れを作るクラス
public class ProcessFlow : MonoBehaviour {

    private UnityEvent event1;
    [SerializeField]
    private SCA sca;
    

    //mainメソッド
    void Start()
    {
        //イベントのインスタンス生成
        event1 = new UnityEvent();
        event1.AddListener(Event1);
    }
    
    void Update ()
    {
        //タップされた時の動作
        if (Input.GetMouseButtonDown(0))
        {

            event1.Invoke();

        }
    }
    void Event1()
    {
        Debug.Log("イベント発生");
    }

}
