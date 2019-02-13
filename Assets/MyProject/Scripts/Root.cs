using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour {

    public List<GameObject> rocketSpawnGo = new List<GameObject>();
    public GameObject rocketPrefab;

    public float timer = 2f;
    private float mTimer;

	void Start ()
    {
        mTimer = timer;
        QualitySettings.vSyncCount = 0;
    }


    private void Update()
    {
        SpawnRockets();
    }


    void SpawnRockets()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            timer = mTimer;
            GameObject rocketClone = Instantiate(rocketPrefab, rocketSpawnGo[Random.Range(0,rocketSpawnGo.Count)].transform.position, transform.rotation);
            rocketClone.transform.parent = transform;
        }


    }
}
