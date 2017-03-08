using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour {

	// ブロックのプレハブを山椒
	public Transform blockPrefab;
	// 上の壁を山椒
	public Transform topWall;
	// 壁を並べる数を指定
	public int placeX;

	// Use this for initialization
	void Start () {
		//配置する座標を設定
		Vector3 placePosition = new Vector3(
			topWall.position.x-topWall.localScale.x/2+blockPrefab.localScale.x/2,
			0,
			topWall.position.z-topWall.localScale.z/2-blockPrefab.localScale.z/2);

		//配置する回転角を設定
		Quaternion q = new Quaternion();
		q= Quaternion.identity;

		//幅を調整
		Vector3 localscale = blockPrefab.localScale;
		localscale.x = topWall.localScale.x / placeX;	// X軸のみ書き換え
		blockPrefab.localScale = localscale;			// blockPrefabに代入

		//配置
		for (int i = 0; i < placeX; i++)
		{
			Instantiate(blockPrefab, placePosition, q);
			placePosition.x += blockPrefab.transform.localScale.x;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
