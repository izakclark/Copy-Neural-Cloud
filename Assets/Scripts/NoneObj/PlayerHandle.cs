using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerHandle : MonoBehaviour
{
    
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 vec3 = Camera.main.WorldToScreenPoint(Input.mousePosition);
            Debug.Log(vec3);
        }
    }

    private void SetObject()
    {
        // ��ġ�� ������Ʈ�� ������Ʈ�� ��ġ Ȯ��
    }

    private void CheckActionAndFuncSelect()
    {
        // ��ġ �ൿ�� ���� �б�� ���
    }

    private void ZoomInOut()
    {
        // ȭ�� ����(�ƿ�)�� �۵��� ���
    }
}
