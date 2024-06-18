// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace RobotAttack
{
    enum Intensity
    {
        Stun, Kill, Destroy
    }
    enum TargetType
    {
        Animals, Humans, Superheroes
    }
    class Target
    {
        public TargetType Type { get; set; }
        public bool IsAlive { get; set; } = true;

        public Target(TargetType type)
        {
            Type = type;
        }
    }

    class Planet
    {
        public bool ContainsLife { get; set; } = true;
    }

    internal class GiantKillerRobot
    {

        public Intensity EyeLaserIntensity { get; set; }
        public List<Target> Targets { get; set; }
        public bool Active { get; set; }
        private int currentTargetIndex;

        public Target CurrentTarget => Targets[currentTargetIndex];

        public void Initialize()
        {
            Active = true;
            currentTargetIndex = 0;
        }
        public void FireLaserAt(Target target)
        {
            if (EyeLaserIntensity == Intensity.Kill)
            {
                target.IsAlive = false;
                Console.WriteLine($"Fired at {target.Type} - Target is now dead.");
            }
        }
        public void AcquireNextTarget()
        {
            currentTargetIndex++;
            if (currentTargetIndex >= Targets.Count)
            {
                Active = false;
                Console.WriteLine("No more targets left. Robot is now inactive.");
            }
        }
    }
}
