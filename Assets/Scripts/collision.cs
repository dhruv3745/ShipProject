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
      if (other.tag=="ShipChar")
       // {
        //    col=true;
            //Object.Destroy(gameObject);
            Debug.Log("CoinHit");
            this.gameObject.SetActive(false);
        //}
    }

    // Update is called once per frame
    void Update()
    {
    //    if (col == true){
    //    }
    }
}


