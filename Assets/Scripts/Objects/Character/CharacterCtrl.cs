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
        dis = Vector3.Distance(thisGameObj.transform.position,enemyObj.transform.position);
        enemy = enemyObj;
    }
}
public class CharacterCtrl : CharacterScript
{
    public GameObject tgt;
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
        GameObject[] reaminEnemy = GameObject.FindGameObjectsWithTag("ENEMY");
        foreach(GameObject obj in reaminEnemy)
        {
            list.Add(new HowLong(this.gameObject, obj));
        }
        list = list.OrderBy(x => x.dis).ToList();
        tgt = list[0].enemy;
    }

    

    void FindPath()
    {
        
    }

    void Move()
    {

    }

    /* �޸� : ĳ���� �̵��� ���Ͽ�
    ? if1 �ɸ��Ͱ� �̵� �Ϸ��� ����

    ! ĳ������ ��Ÿ� ���� ���� ���� �� and ���� �ʵ� ���� ������ ���
    
    ? if2 ĳ������ ��Ÿ� ���� ���� ���� ��� but �ʵ忡 ���� �ִ�
    
    ! Ÿ���� �̵��Ͽ� �ִ� ��Ÿ����� ������ �̵��Ѵ�
    
    ? if3 ĳ������ ��Ÿ� �� �ټ��� ���� ���� ���
    
    ! ���� ����� ��븦 ����, ���� �Ѵ�
    
    ? if4 ĳ������ ��Ÿ� �� �ټ��� ���� ���� ���

    ! if3�� ��� ����
    ' �׷����� �Ÿ��� ���ٸ� ���� Ž���Ҷ� ���� Ž���� ���� �����Ѵ�

    ? if5 ���� �̵� ������ ��ֹ�(����x), ������(����o), �Ʊ�or���� ���� ���
    ! ������ ������ ���� ���� �ʴ� ��� ��ȸ�ϸ� if2�� ��� ��ŭ �̵��Ѵ�
    ' ������ ��ֹ� ������ ������ ������ ��ֹ��� �ı��ϰ� �����Ѵ�
    '' ������ ��ֹ��� ������ ������Ʈ (ex : ������, �Ʊ�)�� ���Ͽ� ���� ��� ��ֹ��� �����ϸ� �׷� ��ֹ��� ���� ��� ����Ѵ�

    ? if6 ĳ���Ͱ� ��ĥ �� �ִ°�
    ! ����(�̵� ��ġ)��/�� ��ĥ ���� ������ ������(���� ��ġ)�� ��ħ���� ���� ĳ���Ͱ� ���������� �ȵ�

    */
}
