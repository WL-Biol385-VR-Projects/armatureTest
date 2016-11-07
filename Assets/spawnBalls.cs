using UnityEngine;
using System.Collections;

public class spawnBalls : MonoBehaviour {

    public Transform ballPrefab;
    public int ballCount;

	// Use this for initialization
	void Start () {
	
        for(var i = 0; i < ballCount; i++)
        {
            Instantiate(ballPrefab, new Vector3(0, 0, i), Quaternion.identity);
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
