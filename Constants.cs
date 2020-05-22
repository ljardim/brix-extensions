using System.Collections.Generic;
using UnityEngine;

namespace Brix.Extensions {
    public static class Constants {
        public enum Direction {
            Forward,
            Backward,
            Left,
            Right,
            Down,
            Up
        }

        public enum PhysicsCastType {
            SingleRayCast,
            SphereCast
        }

        public static readonly Dictionary<Direction, Vector3> DirectionMap = new Dictionary<Direction, Vector3> {
            {Direction.Backward, Vector3.back},
            {Direction.Forward, Vector3.forward},
            {Direction.Left, Vector3.left},
            {Direction.Right, Vector3.right},
            {Direction.Up, Vector3.up},
            {Direction.Down, Vector3.down}
        };

        public static class Menus {
            public const string ROOT = "Brix/";
            public const string STATE = ROOT + "State/";
            public const string ACTIONS = ROOT + "Actions/";
            public const string VARIABLES = ROOT + "Variables/";
            public const string CONDITIONS = ROOT + "Conditions/";
        }
    }
}