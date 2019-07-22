using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityCard : MonoBehaviour {

	/*** VARIABLES ***/
	//skills
	public Skill skill1;
	public Skill skill2;

	//stat boosting
	public int hp;
	public int intelligence;
	public int will;
	public int speed;

	
	/*** FUNCTIONS ***/

	/* Skills */

	//first skill
	public void SetSkill1(Skill skill) {
		skill1 = skill;
	}
	public Skill GetSkill1() {
		return skill1;
	}

	//Second skill
	public void SetSkill2(Skill skill) {
		skill2 = skill;
	}
	public Skill GetSkill2() {
		return skill2;
	}

	/* Stats */

	//hp
	public void SetHP(int val) {
		hp = val;
	}
	public int GetHP() {
		return hp;
	}

	//intelligence
	public void SetIntelligenc(int val) {
		intelligence = val;
	}
	public int GetIntelligence() {
		return intelligence;
	}

	//will
	public void SetWill(int val) {
		will = val;
	}
	public int GetWill() {
		return will;
	}

	//speed
	public void SetSpeed(int val) {
		speed = val;
	}
	public int GetSpeed() {
		return speed;
	}
}
