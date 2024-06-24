using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
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
        // ���݂̃J�����ʒu���擾
        Vector3 currentPosition = transform.position;

        // �v���C���[��Y���̕ω��݂̂�Ǐ]
        currentPosition.y = target.position.y + offset.y;

        // �V�����ʒu���J�����ɐݒ�
        transform.position = currentPosition;
    }
    /*/
    void LateUpdate()
    {
        gameObject.transform.position = target.transform.position + offset;
    }
    /*/
}
