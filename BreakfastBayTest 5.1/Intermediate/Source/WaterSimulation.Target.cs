using UnrealBuildTool;

public class WaterSimulationTarget : TargetRules
{
	public WaterSimulationTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("WaterSimulation");
	}
}
