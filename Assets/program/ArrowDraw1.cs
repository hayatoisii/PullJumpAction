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
        //0�F���N���b�N
        //1�F�E�N���b�N

        arrowImage.gameObject.SetActive(false);

        //�������u��
        if (Input.GetMouseButtonDown(0))
        {
            //�}�E�X�̍��W��ۑ�����
            clickPosition = Input.mousePosition;
        }
        //�������u��
        if (Input.GetMouseButton(0))
        {
            arrowImage.gameObject.SetActive(true);

            Vector3 dist = clickPosition - Input.mousePosition;
            //�x�N�g���̒������Z�o
            float size = dist.magnitude;
            //�x�N�g������p�x�Z�o
            float angleRad = Mathf.Atan2(dist.y, dist.x);
            //���̉摜��click�����ꏊ�ɉ摜���ړ�
            arrowImage.rectTransform.position = clickPosition;
            //���̉摜���x�N�g������Z�o�����p�x��x���@�ɕϊ�����Z����]
            arrowImage.rectTransform.rotation =
               Quaternion.Euler(0, 0, angleRad * Mathf.Rad2Deg);
            //���̉摜�̑傫�����h���b�N�������ɍ��킹��
            arrowImage.rectTransform.sizeDelta = new Vector2(size, size);

        }

    }
}
