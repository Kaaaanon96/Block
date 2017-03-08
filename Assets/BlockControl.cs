using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour {

	// ブロックのプレハブを山椒
	public GameObject blockPrefab;

	// Use this for initialization
	void Start () {
		
		//配置する座標を設定
		Vector3 placePosition = new Vector3(-8,0,9);
		//配置する回転角を設定
		Quaternion q = new Quaternion();
		q= Quaternion.identity;
		//配置
		for (int i = 0; i < 5; i++)
		{
			Instantiate(blockPrefab, placePosition, q);
			placePosition.x += blockPrefab.transform.localScale.x;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
