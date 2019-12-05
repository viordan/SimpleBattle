using System.Collections;
using UnityEngine;

public partial class Enemy : CharacterBase {

	Coroutine timeToRollCoroutine;
	void SecondsToNextRoll(float seconds) {
		if (timeToRollCoroutine != null) StopCoroutine(timeToRollCoroutine);
		if (attackCoroutine != null) StopCoroutine(attackCoroutine);
		timeToRollCoroutine = StartCoroutine(TimeToRollCoroutine(seconds));
	}

	IEnumerator TimeToRollCoroutine(float seconds) {
		yield return new WaitForSeconds(seconds);
		Roll();
	}
	void Roll() {
		print("Rolling...Rolling....Rolling!");
		int randomRoll = Random.Range(0, 9);
		if (randomRoll < 2) { // 0,1 special attack
			enemyState = State.specialAttack;
		} else if (randomRoll >= 2 && randomRoll < 7) { // 2,3,4,5,6 normal attack
			enemyState = State.normalAttack;
		} else { // 7,8,9 idle
			enemyState = State.idle;
		}
	}

}

