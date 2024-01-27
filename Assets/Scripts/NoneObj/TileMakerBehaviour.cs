using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMakerBehaviour : MonoBehaviour
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
    }

    // 직선간격 = 오브젝트 스케일 - 0.5
    // 대각 x간격 = 직선간격 / 2 || 대각 z 간격 = 오브젝트 스케일 - 1
    void MakeTile()
    {
        float tileDis = tileObj.transform.localScale.x - 0.5f;
        float x = 0, z = 0;
        bool isOddNumTile = true;

        for(int i = 0; i < xScale * zScale - (xScale - zScale); ++i)
        {
            tiles.Add(Instantiate(tileObj));
            tiles[i].name = i.ToString();
            tiles[i].transform.parent = this.transform;
        }
        
        foreach(var tile in tiles)
        {
            switch(isOddNumTile)
            {
                case false:
                    tile.transform.position = new Vector3(tileDis / 2 + tileDis* x, 0, (tileDis - 0.5f) * z);
                    ++x;
                    if(x == xScale -1)
                    {
                        isOddNumTile = true;
                        x = 0;
                        --z;
                    }
                    break;
                default:
                    tile.transform.position = new Vector3(tileDis * x, 0, (tileDis - 0.5f) * z); ;
                    ++x;
                    if(x == xScale)
                    {
                        isOddNumTile = false;
                        x = 0;
                        --z;
                    }
                    break;
            }
        }
        
    }


}
