using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowDraw1 : MonoBehaviour
{

    [SerializeField]
    private Image arrowImage;
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

        arrowImage.gameObject.SetActive(false);

        //押した瞬間
        if (Input.GetMouseButtonDown(0))
        {
            //マウスの座標を保存する
            clickPosition = Input.mousePosition;
        }
        //離した瞬間
        if (Input.GetMouseButton(0))
        {
            arrowImage.gameObject.SetActive(true);

            Vector3 dist = clickPosition - Input.mousePosition;
            //ベクトルの長さを算出
            float size = dist.magnitude;
            //ベクトルから角度算出
            float angleRad = Mathf.Atan2(dist.y, dist.x);
            //矢印の画像をclickした場所に画像を移動
            arrowImage.rectTransform.position = clickPosition;
            //矢印の画像をベクトルから算出した角度を度数法に変換してZ軸回転
            arrowImage.rectTransform.rotation =
               Quaternion.Euler(0, 0, angleRad * Mathf.Rad2Deg);
            //矢印の画像の大きさをドラック↓距離に合わせる
            arrowImage.rectTransform.sizeDelta = new Vector2(size, size);

        }

    }
}
