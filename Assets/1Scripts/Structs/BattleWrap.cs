using UnityEngine;

public struct BattleWrap {

	public BattleWrap(Transform battleHolder) {
		battleGameObject = battleHolder.gameObject;
		battleTransform = battleHolder;
		playerBattlePosition = battleHolder.GetChild(1);
		playerEnterPosition = battleHolder.GetChild(2);
		enemyPositions = new Transform[5];
		for (int i = 0; i < battleHolder.GetChild(0).childCount; i++) { // add positions to array
			enemyPositions[i] = battleHolder.GetChild(0).GetChild(i);
		}
	}
	public GameObject battleGameObject { get; set; }
	public Transform battleTransform { get; set; }
	public Transform playerBattlePosition { get; set; }
	public Transform playerEnterPosition { get; set; }
	public Transform[] enemyPositions { get; set; }
}
