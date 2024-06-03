using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowDraw : MonoBehaviour
{

    private Vector3 clickPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //0：左クリック
        //1：右クリック

        //押した瞬間
        if (Input.GetMouseButtonDown(0))
        {
            //マウスの座標を保存する
            clickPosition = Input.mousePosition;
        }
        //離した瞬間
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 dist = clickPosition - Input.mousePosition;
            Debug.Log(dist);
        }
    }
}
