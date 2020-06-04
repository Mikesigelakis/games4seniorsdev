﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public GameObject destroyedParticle;
    public int firstChildCount, countOfChildren, maxDestroyable, minDestroyable, destroyable, destroyableIndex;
    public bool destroyed = false;
    private Transform objTransform;

	void Start () {
        objTransform = GetComponent<Transform>();
        firstChildCount = countOfChildren = objTransform.childCount;
        maxDestroyable = (int)(countOfChildren - (countOfChildren / 2));
        minDestroyable = (int)(countOfChildren / 2);
        destroyable = (int)Random.Range(minDestroyable, maxDestroyable + 1);
        FindObjectOfType<Player>().ammoCount = firstChildCount - destroyable;        
    }
	
	void LateUpdate () {
        countOfChildren = objTransform.childCount;       

        if (countOfChildren > (firstChildCount - destroyable))     
            Destroy();
	}

    public void Destroy()
    {
        destroyableIndex = Random.Range(0, countOfChildren);        
        Destroy(Instantiate(destroyedParticle, objTransform.GetChild(destroyableIndex).transform.position, Quaternion.identity), 1f);       //Instantiates destroyedParticle to the selected cube's position and destroys it after x seconds
        Destroy(objTransform.GetChild(destroyableIndex).gameObject);
    }
}
