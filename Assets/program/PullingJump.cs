using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringJump : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 clickPosition;
    [SerializeField]
    private float jumpPower = 10;
    private bool isCanJump;
    public GameObject particlePrefab;
    public Transform player;
    private Animator animator;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

        Screen.SetResolution(1920, 1080, false);

        rb = gameObject.GetComponent<Rigidbody>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if (isCanJump && Input.GetMouseButtonUp(0))
        {

            //クリックした座標と離した座標の差分を無視
            Vector3 dist = clickPosition - Input.mousePosition;
            //クリックとリソースが同じ座標ならば無視
            if (dist.sqrMagnitude == 0) { return; }
            //差分を標準化し、jumpPowerをかけ合わせた値を移動量とする
            rb.velocity = dist.normalized * jumpPower;

            audioSource.Play();

            for (int i = 0; i < 10; i++)
            {
                Instantiate(particlePrefab ,player.position, Quaternion.identity);
            }
        }
    }


    private void OnCollisionStay(Collision collision)
    {
        //地面

        // 衝突している天の情報が複数格納されている
        ContactPoint[] contacts = collision.contacts;
        // 0番目の衝突情報から、衝突している点の法線を取得
        Vector3 otherNormal = contacts[0].normal;
        // 上方向を示すベクトル。長さ1。
        Vector3 upVector = new Vector3(0, 1, 0);
        // 上方向と法線のない席。二つのベクトルはともに長さが一なので、cosθの結果がdotUNに入る。
        float dotUN = Vector3.Dot(upVector, otherNormal);
        // 内積値に逆三角関数arccosを掛けて角度を算出。それを度数法へ変換する。これで角度が算出できた。
        float dotDeg = Mathf.Acos(dotUN) * Mathf.Rad2Deg;
        // 二つのベクトルがなす角度が45度より小さければ再びジャンプ可能とする。
        if (dotDeg <= 45)
        {
            isCanJump = true;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        //空中
        isCanJump = false;
    }

}
