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
        //0�F���N���b�N
        //1�F�E�N���b�N

        //�������u��
        if (Input.GetMouseButtonDown(0))
        {
            //�}�E�X�̍��W��ۑ�����
            clickPosition = Input.mousePosition;
        }
        //�������u��
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 dist = clickPosition - Input.mousePosition;
            Debug.Log(dist);
        }
    }
}
