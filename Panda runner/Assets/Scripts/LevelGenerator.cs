using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    //write a code that deletes sections we've passed
    public GameObject[] section;
    private GameObject[] coins;
    public bool creatSection = false;
    public int zPos = 80;
    int secNumb;
    int copynum;
    public float CreateSec = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        section = GameObject.FindGameObjectsWithTag("Section");
        coins = GameObject.FindGameObjectsWithTag("Coin");
        if (creatSection == false)
        {
            creatSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNumb = Random.Range(0, section.Length);
        
        foreach(GameObject coin in coins)
        {
            coin.SetActive(true);
        }
        Instantiate(section[secNumb], new Vector3(0, -0.5f, zPos), Quaternion.identity);
        zPos +=160;
        yield return new WaitForSeconds(CreateSec);
        creatSection = false;
    }
}
