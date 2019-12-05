using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour, IHittable, IHealable {
	protected Stats stats = new Stats();

	protected Reaction myReaction;

	public void Stats(int _health, int _strength, int _damage, int _maxHealth, int _armor) {
		stats.health = _health;
		stats.maxHealth = _maxHealth;
		stats.damage = _damage;
		stats.strength = _strength;
		stats.armor = _armor;
	}

	public void GettingHit(int damage) {
		switch (myReaction) {
			case Reaction.blocking:
			print(gameObject.name + " says : " + "NICE TRY! I BLOCKED YOU!");
			break;
			case Reaction.vulnerable:
			print(gameObject.name + " says : " + "YOU HIT ME!");
			TakeDamage(damage);
			break;
			case Reaction.attacking:
			print(gameObject.name + " says : " + "I HIT YOU!!!");
			HitTarget();
			break;
		}
	}

	protected virtual void HitTarget() { 
		
	}

	public void TakeDamage(int damage) {
		if (damage - stats.armor > 0) stats.health -= (damage - stats.armor);
		if (stats.health <= 0) Death();
	}

	public void Heal(int health){
		stats.health += health;
		if(stats.health>stats.maxHealth) stats.health=stats.maxHealth;
	}

	public void Death() {
		print("you went and died");
        Destroy(gameObject);
		//TODO some death logic
	}
}
public enum State {
	idle,
	normalAttack,
	specialAttack,
	dizzyFromAttack,
	block
}

public enum Reaction { // this determines what the enemy will do when hit
	blocking, // if he enemy will block
	vulnerable, // if hit enemy will take damage
	attacking // if hit enemy will ignore hit
}
