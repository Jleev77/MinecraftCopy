
using System;
using UnityEngine;

public class OneShotAttackable : MonoBehaviour, IAttackable
{
    public void Attack(Attacker attacker)
    {
        Destroy(gameObject);
    }
}
