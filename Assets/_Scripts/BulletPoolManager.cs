using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{

    //TODO: create a structure to contain a collection of bullets
    public List<GameObject> pooledBullets;
    public GameObject bullet;
    public int amountPool;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool
        //instantiate like 10 of them 
        for (int i = 0; i < amountPool; i++)
        {
            GameObject stuff = (GameObject)Instantiate(bullet);
            stuff.SetActive(false);
            pooledBullets.Add(stuff); 
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {

        return bullet;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        //bullet.transform.position = BulletSpawn; 
        //want to reset the position to bulletspawn, where its being instantiated 
    }
}
