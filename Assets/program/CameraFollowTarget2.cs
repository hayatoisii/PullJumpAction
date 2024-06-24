using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pullingjump2 : MonoBehaviour
{
    // カメラが追従するターゲット（プレイヤー）
    public Transform target;

    // カメラとターゲットのオフセット
    private Vector3 offset;

    void Start()
    {
        // 初期のオフセットを計算
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        gameObject.transform.position = target.transform.position + offset;
    }

}
