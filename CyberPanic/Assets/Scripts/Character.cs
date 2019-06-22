/***
Characters will have a 1-5 abilities to choose from as a base skill
Each character can equip up to 3 ability cards
Each ability card will have 2 skills to augment the character

In the battle field the character will have access to 4 skills
	- choosing one skill from their base kit
	- choosing one skill per card

 * ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

	enum Stat {HP, SP, Damage, Protection, Intelligence, Will, Speed };

	public string CharacterName;
	public int HP; //hit points
	public int SP; //skill points
	public int Damage; //attack points
	public int Protection; //Defense points
	public int Intelligence; //attack boosting stat
	public int Will; //defense bosting stat
	public int Speed; //SP regeneration and/or cooldown reduction

}