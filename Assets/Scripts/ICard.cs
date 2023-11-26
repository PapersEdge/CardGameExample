using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICard
{
	public void OnAttack();
	public void OnDefend();
	public void OnSummoned();
	public void OnDestroyed();
}
