using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCtrl : MonoBehaviour
{
    [Tooltip("타일 오브젝트")]
    public GameObject tileObj;

    public List<GameObject> tiles;

    public float xScale;

    public float zScale;

    // Start is called before the first frame update
    void Start()
    {
        MakeTile();
        SetTile();
    }

    void MakeTile()
    {
        for(int i = 0; i < xScale * zScale - (xScale - zScale); ++i)
        {
            tiles.Add(Instantiate(tileObj));
            tiles[i].name = i.ToString();
            tiles[i].transform.parent = this.transform;
        }
       
    }

    void SetTile()
    {
        float tileDis = tileObj.transform.localScale.x - 0.5f; // 4.5
        float getPosX = tileDis * (int)Mathf.Abs(xScale / 2) * Vector2.left.x; // 13.5
        float getPosZ = tileDis * (int)Mathf.Abs(zScale / 2) - Vector2.up.y; // 8        
        float x = 0, z = 0;
        bool isOddNumTile = true;

        foreach (var tile in tiles)
        {
            switch (isOddNumTile)
            {
                case false:
                    tile.transform.position = new Vector3( getPosX + (tileDis / 2) + tileDis * x, 0, getPosZ - (tileDis - 0.5f) * z);
                    ++x;
                    if (x == xScale - 1)
                    {
                        isOddNumTile = true;
                        x = 0;
                        ++z;
                    }
                    break;
                default:
                    tile.transform.position = new Vector3(getPosX + tileDis * x, 0, getPosZ - (tileDis -0.5f) * z) ;
                    ++x;
                    if (x == xScale)
                    {
                        isOddNumTile = false;
                        x = 0;
                        ++z;
                    }
                    break;
            }
        }
    }
}
