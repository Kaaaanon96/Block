using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour {

	// ブロックのプレハブを山椒
	public Transform blockPrefab;
	// 上の壁を山椒
	public Transform topWall;
	// 壁を並べる数を指定(横)
	public int placeX;
	// 壁を並べる数を指定(縦)
	public int placeZ;

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
		localscale.x = topWall.localScale.x / placeX;	// 配置する壁のX軸の長さ
		blockPrefab.localScale = localscale;			// blockPrefabに代入


		//配置
		// 横にplaceXこ並べて、縦にplaceZこ並べる
		for(int i = 0; i < placeZ; i++)
		{
			// 並べるZ軸の位置の指定
			Vector3 currentPlacePosition = placePosition - Vector3.forward * blockPrefab.localScale.z * i;
			for (int y = 0; y < placeX; y++)
			{
				// X軸(横)にそって並べる
				// InstantiateでblockPrefabをcurrentPlacePositionの位置にqの回転角で設置.
				Instantiate(blockPrefab, currentPlacePosition, q);
				currentPlacePosition.x += blockPrefab.transform.localScale.x;
			}
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
