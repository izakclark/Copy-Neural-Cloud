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
        // 터치시 오브젝트와 오브젝트의 위치 확인
    }

    private void CheckActionAndFuncSelect()
    {
        // 터치 행동에 따라 분기될 기능
    }

    private void ZoomInOut()
    {
        // 화면 줌인(아웃)에 작동할 기능
    }
}
