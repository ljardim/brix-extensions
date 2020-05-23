using Brix.State;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [CreateAssetMenu(menuName = Constants.Menus.CONDITIONS + "Int Comparison")]
    public class IntComparison : Condition {
        [SerializeField]private IntReference valueToCheck;
        [SerializeField]private IntReference expectedValue;
        public override bool CheckCondition() {
            return valueToCheck.Equals(expectedValue);
        }
    }
}