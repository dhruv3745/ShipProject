using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    //private bool col = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
      //  if (target.transform.gameObject.name=="shipSprite")
       // {
        //    col=true;
            //Object.Destroy(gameObject);
            this.gameObject.SetActive(false);
            Debug.Log("hello");
        //}
    }

    // Update is called once per frame
    void Update()
    {
    //    if (col == true){
    //    }
    }
}