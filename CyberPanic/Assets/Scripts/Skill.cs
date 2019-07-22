using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//enum Stats {HP, SP, Damage, Protection, Intelligence, Will, Speed };

public class Skill : MonoBehaviour
{

	public string skillName;
	public int SPCost;

	//Adding stats to the character
	public Character.Stat statModified;
	public int statModifier;

	//Dealing damage / heals
	public Character.Stat statEffected;
	public int effectPotency;





}
