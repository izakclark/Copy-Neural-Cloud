using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Node
{
    public bool isObstacle;
    public Node parentNode;
    public float x, y;
    public int G, H;

    public int F
    {
        get
        {
            return G + H;
        }
    }

    public Node(bool itsObjstacle, int x, int y)
    {
        this.isObstacle = itsObjstacle;
        this.x = x;
        this.y = y;
    }
}
public class KeyFloat
{
    float x, y;
    KeyFloat(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
}
public class PathFindBehaviour : MonoBehaviour
{
    
}

class Noties
{
    /* 캐릭터 길찾기 알고리즘 구현 방법
     *  출발지점의 바닥 게임 오브젝트를 입력한다
     *  도착지점의 바닥 게임 오브젝트를 입력한다
     *  입력은 캐릭터 오브젝트의 trigger를 통해 입력된 값을 가져온다
     *  
     *  경로찾기
     *  목표의 가까운 방향쪽부터 경로 탐색을 시작한다
     *  월드좌표의 수평이 저가, 대각선이 고가, 수직은 이동 불가능
     *  연산이 끝나면 최대 사거리의 타일 위치 경로를 저장
     *  
     *  이동
     *  
     */
}
