using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.layer == 9)
    //    {
    //        Debug.Log("Here");
    //        Destroy(other.gameObject);
    //    }
    //}
}
