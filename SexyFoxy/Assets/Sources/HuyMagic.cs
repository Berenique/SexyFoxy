using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class HuyMagic : MonoBehaviour {

    public GameObject SpawnPrefab;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        for (int i = 0; i < 3; i++)
        {
            var miniHuy = Instantiate(SpawnPrefab, transform.position, Random.rotation);
        }
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
