using UnityEngine;

public struct LevelWrap {

	public LevelWrap( int _levelID, GameObject _mylevel ) {
		id=_levelID;
		levelGameobject=_mylevel;
		levelTransform=_mylevel.transform;
		levelMarker=levelTransform.GetChild(0).gameObject;
		completed=false;
		visited=false;
	}
	public int id { get; set; }
	public bool completed { get; set; }
	public bool visited { get; set; }
	public Transform levelTransform { get; set; }
	public GameObject levelGameobject { get; set; }
	public GameObject levelMarker { get; set; }
}