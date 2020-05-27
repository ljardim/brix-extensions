using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Calculate Move Amount")]
    public class CalculateMoveAmount : AtomAction {
        [Header("Inputs")]
        [SerializeField]private FloatReference horizontal;
        [SerializeField]private FloatReference vertical;

        [Header("Outputs")]
        [SerializeField]private FloatReference moveAmount;

        public override void Do() {
            moveAmount.Value = Mathf.Clamp01(Mathf.Abs(horizontal.Value) + Mathf.Abs(vertical.Value));
        }
    }
}