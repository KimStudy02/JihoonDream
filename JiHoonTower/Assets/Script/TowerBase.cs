using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBase : MonoBehaviour
{
    public SpriteRenderer towerBody;
    public SpriteRenderer towerRoof;

    private void Awake()
    {
        //int towerBodyLayerID = SortingLayer.NameToID("TowerBody");
        //int towerRoofLayerID = SortingLayer.NameToID("TowerRoof");
        //towerBody.sortingLayerID = SortingLayer.GetLayerValueFromID(towerBodyLayerID);
        //towerRoof.sortingLayerID = SortingLayer.GetLayerValueFromID(towerRoofLayerID);

        towerBody.sortingLayerName = "TowerBody";
        towerRoof.sortingLayerName = "TowerRoof";
    }
}
