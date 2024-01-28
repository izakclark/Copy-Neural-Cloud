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
    public float howFallbyTile = 5f;

    [Range(0.01f, 1.0f)]
    public float followSpd = 0.1f;

    public float delayTime = 1.0f;

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

        if(Input.GetMouseButton(0))
        {
            if (selectedChar != null)
            {
                while (Input.GetMouseButton(0))
                {
                    yield return new WaitForSeconds(0.3f);

                    PackItUp(Input.GetMouseButton(0));
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

    private void PackItUp(bool isGetMouseButton)
    {
        switch(isGetMouseButton)
        {
            case true:
                RaycastHit[] hits = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition));

                foreach (RaycastHit hitobj in hits)
                {
                    if (hitobj.collider.CompareTag("TILE"))
                        curTile = hitobj.collider.gameObject;
                }
                selectedChar.transform.position =
                    new Vector3(curTile.transform.position.x, howFallbyTile, curTile.transform.position.z);
                break;
                case false:
                selectedChar.transform.position =
                    new Vector3(curTile.transform.position.x, howFallbyTile/2, curTile.transform.position.z);
                break;
        }
        

        /*Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float disPosX = Mathf.Abs(pos.x) - Mathf.Abs(selectedChar.transform.position.x);
        float disPosZ = Mathf.Abs(pos.y) - Mathf.Abs(selectedChar.transform.position.z);

        pos.x = pos.x - disPosX;
        pos.z = pos.y - disPosZ;
        pos.y = howFallbyTile;

        selectedChar.transform.position = pos;*/
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
