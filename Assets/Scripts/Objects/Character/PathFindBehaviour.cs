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
    /* ĳ���� ��ã�� �˰��� ���� ���
     *  ��������� �ٴ� ���� ������Ʈ�� �Է��Ѵ�
     *  ���������� �ٴ� ���� ������Ʈ�� �Է��Ѵ�
     *  �Է��� ĳ���� ������Ʈ�� trigger�� ���� �Էµ� ���� �����´�
     *  
     *  ���ã��
     *  ��ǥ�� ����� �����ʺ��� ��� Ž���� �����Ѵ�
     *  ������ǥ�� ������ ����, �밢���� ��, ������ �̵� �Ұ���
     *  ������ ������ �ִ� ��Ÿ��� Ÿ�� ��ġ ��θ� ����
     *  
     *  �̵�
     *  
     */
}
