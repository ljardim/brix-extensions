﻿using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Brix;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Grounded Check - Physics")]
    public class GroundedCheckPhysics : AtomAction {
        [Header("Inputs")]
        [SerializeField]private LayerMask ignoreLayers;
        [SerializeField]private TransformReference targetTransform;
        
        [Header("Configuration")]
        [SerializeField]private FloatReference offsetFromTargetTransformPosition = new FloatReference(0.7f);
        [SerializeField]private Constants.Direction rayCastDirection = Constants.Direction.Down;
        [SerializeField]private Constants.PhysicsCastType castType = Constants.PhysicsCastType.SingleRayCast;
        [SerializeField]private FloatReference groundedRayCastDistance = new FloatReference(0.8f);
        [SerializeField]private FloatReference inAirGroundedRayCastDistance = new FloatReference(0.85f);
        [SerializeField]private FloatReference sphereRadius = new FloatReference(0.3f);

        [Header("Outputs")]
        [SerializeField]private BoolReference groundedBool;
        
        public override void Do() {
            var origin = targetTransform.Value.position;
            origin.y += offsetFromTargetTransformPosition.Value;
            var direction = Constants.DirectionMap[rayCastDirection];
            var distance = groundedBool.Value ? groundedRayCastDistance : inAirGroundedRayCastDistance;

            switch (castType) {
                case Constants.PhysicsCastType.SingleRayCast:
                    groundedBool.Value = Physics.Raycast(origin, direction, out _, distance.Value, ~ignoreLayers);
                    break;
                case Constants.PhysicsCastType.SphereCast:
                    groundedBool.Value = Physics.SphereCast(origin, sphereRadius.Value, direction, out _, distance.Value, ~ignoreLayers);
                    break;
                default:
                    throw new System.ArgumentOutOfRangeException();
            }
            Debug.DrawRay(origin, direction * distance.Value, groundedBool.Value ? Color.green : Color.red);
        }
    }
}