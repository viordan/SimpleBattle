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
	}
	public int id { get; set; }
	public string name { get; set; }
	public GameObject planetGameObject { get; set; }
	public Transform planetTransform { get; set; }
	public Transform orbit { get; set; }
	public Transform cameraLocation { get; set; }
	public int numberOfLevels { get; set; }
	public bool stopRotation {
		set => orbit.GetComponent<Rotate>().stopRotation = value;
	}
	public bool enableCollider {
		set => planetGameObject.GetComponent<SphereCollider>().enabled = value;
	}
	// dictionary is used  to reference the Transfrom in scene to Level object 
	public Dictionary<Transform, LevelWrap> levels;

}
