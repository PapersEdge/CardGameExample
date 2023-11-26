using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
	public CardData cardData;
	public MeshRenderer cardArtMat;
	public TextMeshPro nameText;
	public TextMeshPro descriptionText;
	public TextMeshPro statsText;

	// Start is called before the first frame update
	void Start()
    {
		cardArtMat.material.SetTexture("_MainTex", cardData.cardArt);
		nameText.text = cardData.cardName + "\n" + cardData.type;
		descriptionText.text = cardData.description;
		statsText.text = "ATK: " + cardData.ATK + "\t\t\t\tDEF: " + cardData.DEF;
	}

    // Update is called once per frame
    void Update()
    {

    }
}
