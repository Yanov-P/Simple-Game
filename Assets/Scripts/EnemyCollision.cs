using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private int _colsNum = 0;
    public Material _orangeMaterial;

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag != "Player") return;
        if (_colsNum == 0)
        {
            _colsNum++;
            GetComponent<Renderer>().material = _orangeMaterial;
            Debug.Log("first col");
            col.gameObject.GetComponent<PlayerControls>().MoveEnemy(transform);
        }
        if(_colsNum == 1)
        {
            _colsNum++;
            col.gameObject.GetComponent<PlayerControls>().SpawnEnemy();
        }
        if (_colsNum == 2)
        {
            Destroy(this.gameObject);
        }
    }

}
