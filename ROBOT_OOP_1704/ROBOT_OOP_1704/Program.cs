// See https://aka.ms/new-console-template for more information
using RobotAttack;

GiantKillerRobot robot = new GiantKillerRobot();
robot.Initialize();

robot.EyeLaserIntensity = Intensity.Kill;

robot.Targets = new List<Target>
 {
    new Target(TargetType.Animals),
    new Target(TargetType.Humans),
    new Target(TargetType.Superheroes)
 };

Planet earth = new Planet();

while (robot.Active && earth.ContainsLife)
{
    if (robot.CurrentTarget.IsAlive)
    {
        robot.FireLaserAt(robot.CurrentTarget);
    }
    else
    {
        robot.AcquireNextTarget();
    }
}

