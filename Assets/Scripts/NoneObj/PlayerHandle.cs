using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerHandle : MonoBehaviour
{
    public GameObject selectedChar;
    public GameObject curTile;
    public GameObject originTile;

    public float distanceFromCam = 10f;

    [Range(0.01f, 1.0f)]
    public float followSpd = 0.1f;

    private Vector3 mousePos;
    private Vector3 nextPos;
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SetObject();
            StartCoroutine(CheckActionAndFuncSelect());
        }
    }

    private void SetObject()
    {

        // 터치시 오브젝트와 오브젝트의 위치 확인
        selectedChar = null;
        curTile = null;
        originTile = null;

        RaycastHit[] hits = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition));

        foreach(RaycastHit hitobj in hits)
        {
            if (hitobj.collider.CompareTag("P_CHAR"))
                selectedChar = hitobj.collider.gameObject;             
            else if(hitobj.collider.CompareTag("TILE"))
                originTile = hitobj.collider.gameObject;
        }
    }

    private IEnumerator CheckActionAndFuncSelect()
    {
        // 터치 행동에 따라 분기될 기능

        yield return new WaitForSeconds(0.3f);

        bool isGetMouseButton = Input.GetMouseButton(0);

        if(isGetMouseButton)
        {
            if (selectedChar != null)
            {
                while (isGetMouseButton)
                {
                    SetCharPos(Input.GetMouseButton(0));

                    yield return new WaitForSeconds(0.3f);

                    isGetMouseButton = Input.GetMouseButton(0);
                }
            }
            else
                yield break;
        }
        else
        {
            ShowInfo();
            yield break;
        }
    }

    private void SetCharPos(bool isGetMouseButton)
    {
        mousePos = Input.mousePosition;
        mousePos.z = distanceFromCam;

        nextPos = Camera.main.ScreenToWorldPoint(mousePos);
        selectedChar.transform.position = Vector3.Lerp(selectedChar.transform.position, nextPos, followSpd);
    }

    private void ShowInfo()
    {
        Debug.Log("4");
    }

    private void ZoomInOut()
    {
        // 화면 줌인(아웃)에 작동할 기능
    }
}
