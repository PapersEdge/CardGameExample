using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCardData", menuName = "ScriptableObjects/CardData", order = 1)]
public class CardData : ScriptableObject
{
	public enum Type
	{
		FIGHTER,
		MAGE,
		SUPPORT
	}
	public string cardName;
	public Type type;
	public int ATK;
	public int DEF;
	public Texture2D cardArt;
	[Space]
	public string description;

}
