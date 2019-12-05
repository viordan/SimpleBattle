using System.Collections;
using UnityEngine;

public partial class Enemy : CharacterBase {
	Coroutine attackCoroutine;

	void Attack(int _windUpPeriod, int _takeDamagePeriod) {
		if (attackCoroutine != null) StopCoroutine(attackCoroutine);
		attackCoroutine = StartCoroutine(AttackCouroutine(_windUpPeriod, _takeDamagePeriod));
	}

	IEnumerator AttackCouroutine(int _windUpPeriod, int _takeDamagePeriod) {
		myReaction= Reaction.blocking;
		print("Start To Attack!!!!");
		yield return new WaitForSeconds(_windUpPeriod);
		myReaction= Reaction.vulnerable;
		print("Now I'm Vulnerable");
		yield return new WaitForSeconds(_takeDamagePeriod);
		myReaction= Reaction.attacking;
		print("Now I'm Unstopable");
	}
}

