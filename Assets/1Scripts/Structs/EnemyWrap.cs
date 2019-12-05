using UnityEngine;

public struct EnemyWrap {

	public EnemyWrap(int _id, string _enemyName, GameObject _myGameObject) {
		id = _id;
		amIPositioned = false;
		myGameobject = _myGameObject;
		enemyName = _enemyName;
		myTransform = _myGameObject.transform;
		myParent = myTransform.parent;
		myOriginalPosition = myTransform.position;
	}
	public int id { get; set; }
	public bool amIPositioned { get; set; }
	public string enemyName { get; set; }
	public Transform myTransform { get; set; }
	public Transform myParent { get; set; }
	public GameObject myGameobject { get; set; }
	public Vector3 myOriginalPosition { get; set; }
}
