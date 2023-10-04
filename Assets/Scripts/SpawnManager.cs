using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 _spawnPosition = new Vector3(25, 0, 0);
    private float _startDelay = 2;
    private float _repeatDelay = 2;
    private PlayerController _playerController;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpawnObstacles", _startDelay, _repeatDelay);
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacles()
    {
        if (_playerController.gameOver == false)
        {
            Instantiate(obstaclePrefab, _spawnPosition, obstaclePrefab.transform.rotation);
        }       
    }
}
