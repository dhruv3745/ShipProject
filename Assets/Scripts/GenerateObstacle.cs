using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacle : MonoBehaviour
{
    public GameObject[] obstacles;
    [SerializeField] private int yPos;
    [SerializeField] private bool creatingObstacle = false;
    //[SerializeField] private bool toCreate = true; 
    [SerializeField] private int rand;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if (creatingObstacle == false) {
            {
                creatingObstacle=true;
                StartCoroutine(InstantiateObstacle());
            }
        }
    }

    IEnumerator InstantiateObstacle()
    {
        rand=Random.Range(0,3);
        yPos = Random.Range(25,100);
        Instantiate(obstacles[rand], new Vector3(0,yPos,0), Quaternion.identity);
        yield return new WaitForSeconds(2);
        creatingObstacle=false;
    }

}
