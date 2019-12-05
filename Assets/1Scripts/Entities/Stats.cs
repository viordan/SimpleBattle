public class Stats {
	public Stats() {
		health = 100;
		maxHealth = 100;
		damage = 10;
		strength = 1;
		armor = 1;
	}

	public Stats(int _health, int _strength, int _damage, int _maxHealth, int _armor) {
		health = _health;
		maxHealth = _maxHealth;
		damage = _damage;
		strength = _strength;
		armor = _armor;
	}
	public int maxHealth { get; set; }
	public int health { get; set; }
	public int strength { get; set; }
	public int armor { get; set; }
	public int damage { get; set; }
}
