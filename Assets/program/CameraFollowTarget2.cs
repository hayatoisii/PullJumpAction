using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pullingjump2 : MonoBehaviour
{
    // �J�������Ǐ]����^�[�Q�b�g�i�v���C���[�j
    public Transform target;

    // �J�����ƃ^�[�Q�b�g�̃I�t�Z�b�g
    private Vector3 offset;

    void Start()
    {
        // �����̃I�t�Z�b�g���v�Z
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        gameObject.transform.position = target.transform.position + offset;
    }

}
