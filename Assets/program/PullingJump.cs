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

            //�N���b�N�������W�Ɨ��������W�̍����𖳎�
            Vector3 dist = clickPosition - Input.mousePosition;
            //�N���b�N�ƃ��\�[�X���������W�Ȃ�Ζ���
            if (dist.sqrMagnitude == 0) { return; }
            //������W�������AjumpPower���������킹���l���ړ��ʂƂ���
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
        //�n��

        // �Փ˂��Ă���V�̏�񂪕����i�[����Ă���
        ContactPoint[] contacts = collision.contacts;
        // 0�Ԗڂ̏Փˏ�񂩂�A�Փ˂��Ă���_�̖@�����擾
        Vector3 otherNormal = contacts[0].normal;
        // ������������x�N�g���B����1�B
        Vector3 upVector = new Vector3(0, 1, 0);
        // ������Ɩ@���̂Ȃ��ȁB��̃x�N�g���͂Ƃ��ɒ�������Ȃ̂ŁAcos�Ƃ̌��ʂ�dotUN�ɓ���B
        float dotUN = Vector3.Dot(upVector, otherNormal);
        // ���ϒl�ɋt�O�p�֐�arccos���|���Ċp�x���Z�o�B�����x���@�֕ϊ�����B����Ŋp�x���Z�o�ł����B
        float dotDeg = Mathf.Acos(dotUN) * Mathf.Rad2Deg;
        // ��̃x�N�g�����Ȃ��p�x��45�x��菬������΍ĂуW�����v�\�Ƃ���B
        if (dotDeg <= 45)
        {
            isCanJump = true;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        //��
        isCanJump = false;
    }

}
