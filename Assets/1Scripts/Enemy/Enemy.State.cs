public partial class Enemy : CharacterBase {

    State enemyState {
        get {
            return enemyState;
        }

        set {
			myReaction = Reaction.blocking;
            switch (value) {
                case State.idle:
                    print("Idling.....");
                    SecondsToNextRoll(2);
                    break;
                case State.normalAttack:
                    print("Hitting Normal!");
                    SecondsToNextRoll(6);
                    Attack(2, 3);
                    break;
                case State.specialAttack:
                    print("Hitting Special Attack!!!!");
                    SecondsToNextRoll(8);
                    Attack(3, 4);
                    break;
                case State.dizzyFromAttack:
                    SecondsToNextRoll(1);
                    print("!!Dizzy From Attack!!");
                    break;
                case State.block:
                default:
                    SecondsToNextRoll(2);
                    print("!!Blocking!!");
                    break;
            }
        }
    }
}
