using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
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
        // 現在のカメラ位置を取得
        Vector3 currentPosition = transform.position;

        // プレイヤーのY軸の変化のみを追従
        currentPosition.y = target.position.y + offset.y;

        // 新しい位置をカメラに設定
        transform.position = currentPosition;
    }
    /*/
    void LateUpdate()
    {
        gameObject.transform.position = target.transform.position + offset;
    }
    /*/
}
