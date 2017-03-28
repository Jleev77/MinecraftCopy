using UnityEngine;

[RequireComponent(typeof(IAttackController))]
public class Attacker : MonoBehaviour
{

    private IAttackController attackController;
    private Target target;

    public void Start()
    {
        attackController = GetComponent<IAttackController>();
        target = transform.parent.GetComponent<Target>();
        if(target == null)
        {
            target = transform.parent.gameObject.AddComponent<Target>();
        }
    }

    public void Update()
    {
        if (!attackController.IsAttacking() || target.CurrentTarget == null) { return; }
        var attackble = target.CurrentTarget.GetComponent<IAttackable>();

        if (attackble != null)
        {
            attackble.Attack(this);
        }
    }
}