using System.Collections.Generic;
using UnityEngine;

public struct PlanetWrap {
	public PlanetWrap(int _planetID, GameObject _myPlanet) {
		id = _planetID;
		name = _myPlanet.name;
		planetGameObject = _myPlanet;
		planetTransform = _myPlanet.transform;
		orbit = planetTransform.parent;
		cameraLocation = orbit.GetChild(1);
		numberOfLevels = planetTransform.childCount;
		levels = new Dictionary<Transform, LevelWrap>();
		Quaternion levelPosition1 = Quaternion.Euler(0, 0, 0);
		Quaternion levelPosition2 = Quaternion.Euler(0, 0, 90);
		Quaternion levelPosition3 = Quaternion.Euler(0, 0, 180);
		Quaternion levelPosition4 = Quaternion.Euler(0, 0, 270);
		Quaternion levelPosition5 = Quaternion.Euler(90, 0, 0);
		Quaternion levelPosition6 = Quaternion.Euler(270, 0, 0);
		levelPositions=new Quaternion[] { levelPosition1, levelPosition2, levelPosition3, levelPosition4, levelPosition5, levelPosition6 };
		allowRotation=true;
	}
	public int id { get; set; }
	public string name { get; set; }
	public GameObject planetGameObject { get; set; }
	public Transform planetTransform { get; set; }
	public Transform orbit { get; set; }
	public Transform cameraLocation { get; set; }
	public int numberOfLevels { get; set; }
	public bool allowRotation {
		set => orbit.GetComponent<Rotate>().allowRotation = value;
	}
	public bool enableCollider {
		set => planetGameObject.GetComponent<SphereCollider>().enabled = value;
	}
	// dictionary is used  to reference the Transfrom in scene to Level object 
	public Dictionary<Transform, LevelWrap> levels;

	public Quaternion[] levelPositions { get; set; }

}
