using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HowLong
{
    public float dis
    { get;  set; }
    public GameObject enemy
    {  get;  set; }

    public HowLong(GameObject thisGameObj, GameObject enemyObj)
    {
        dis = Vector3.Distance(thisGameObj.transform.position, enemyObj.transform.position);
        enemy = enemyObj;
    }
}
public class CharacterCtrl : CharacterScript
{
    public GameObject tgt;
    GameObject[] remainEnemies;
    private void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetTarget();
            
        }
    }

    void GetTarget()
    {
        List<HowLong> list = new List<HowLong>();

        if (this.gameObject.CompareTag("P_CHAR"))
            remainEnemies = GameObject.FindGameObjectsWithTag("ENEMY");

        else
            remainEnemies = GameObject.FindGameObjectsWithTag("P_CHAR");

        foreach(GameObject obj in remainEnemies)
        {
            list.Add(new HowLong(this.gameObject, obj));
        }

        list = list.OrderBy(x => x.dis).ToList();
        tgt = list[0].enemy;
    }



    void PathFind()
    {
        
    }

    void Move()
    {

    }

    /* 메모 : 캐릭터 이동에 관하여
    ? if1 케릭터가 이동 하려는 이유

    ! 캐릭터의 사거리 내에 적이 없을 것 and 적이 필드 위에 남았을 경우
    
    ? if2 캐릭터의 사거리 내에 적이 없을 경우 but 필드에 적은 있다
    
    ! 타일을 이동하여 최대 사거리까지 적에게 이동한다
    
    ? if3 캐릭터의 사거리 내 다수의 적이 있을 경우
    
    ! 제일 가까운 상대를 조준, 공격 한다
    
    ? if4 캐릭터의 사거리 밖 다수의 적이 있을 경우

    ! if3의 답과 같다
    ' 그럼에도 거리가 같다면 적을 탐지할때 먼저 탐지된 적을 공격한다

    ? if5 만약 이동 동선에 장애물(무적x), 지형물(무적o), 아군or적이 있을 경우
    ! 동선이 완전히 막혀 있지 않는 경우 우회하며 if2의 경우 만큼 이동한다
    ' 동선이 장애물 때문에 완전히 막히면 장애물을 파괴하고 접근한다
    '' 동선이 장애물을 제외한 오브젝트 (ex : 지형물, 아군)에 의하여 막힐 경우 장애물을 공격하며 그럴 장애물도 없을 경우 대기한다

    ? if6 캐릭터가 겹칠 수 있는가
    ! 동선(이동 위치)이/가 겹칠 수는 있으나 목적지(정지 위치)의 겹침으로 인해 캐릭터가 겹쳐져서는 안됨

    */
}
