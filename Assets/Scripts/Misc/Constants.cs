using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheNemesis
{
    public enum MatchState { Playing, Paused, Completed }

    public enum Team { Blue = 1, Red }

    public class Constants
    {
        public static readonly string PlayerResourceFolder = "Players";
        public static readonly string DefaultPlayerPrefabName = "Player";

        public static readonly string BallResourceFolder = "Balls";
        public static readonly string DefaultBallPrefabName = "Ball";

        public static readonly float StartDelay = 6;
        public static readonly int GoalsToWin = 3;

    }

    public class Tags
    {
        public static readonly string Ball = "Ball";
        
    }

    public class EventCode
    {
        public static byte ResetGoalArea = 199;
    }
}
