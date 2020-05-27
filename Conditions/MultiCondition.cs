using Brix.State;
using UnityEngine;

namespace Brix.Extensions {
    [CreateAssetMenu(menuName = Constants.Menus.CONDITIONS + "Multi Condition")]
    public class MultiCondition : Condition {
        [SerializeField]private Condition[] conditions;
        [SerializeField]private Constants.Operator op;
        
        public override bool CheckCondition() {
            if (op == Constants.Operator.And) {
                var finalValue = true;
                foreach (var condition in conditions) {
                    finalValue = finalValue && condition.CheckCondition();
                }

                return finalValue;
            } else {
                foreach (var condition in conditions) {
                    if (condition.CheckCondition()) {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}