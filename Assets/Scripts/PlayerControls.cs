using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    public Transform _cameraCenter;
    public float _forceAmount = 1;
    public GameObject _enemyPrefab;
    public Text _scoreText;

    private Vector3 _startPos;
    private int _points;
    private void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(_cameraCenter.forward * _forceAmount, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(-_cameraCenter.forward * _forceAmount, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(-_cameraCenter.right * _forceAmount, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(_cameraCenter.right * _forceAmount, ForceMode.Force);
        }
    }

    public void SpawnEnemy()
    {
        Instantiate(_enemyPrefab, transform.position + new Vector3(Random.Range(0, 4), Random.Range(0, 1), Random.Range(0, 4)), transform.rotation);
        _points++;
        _scoreText.text = _points.ToString();
    }

    public void MoveEnemy(Transform tr)
    {
        tr.position += new Vector3(Random.Range(0, 4), Random.Range(0, 1), Random.Range(0, 4));
    }

    public void Respawn()
    {
        transform.position = _startPos;
    }
}
