// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class seattlevrhack18EditorTarget : TargetRules
{
	public seattlevrhack18EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        ExtraModuleNames.AddRange(new string[] { "seattlevrhack18" });
		//bUseUnityBuild = false;
		//bUsePCHFiles = false;
    }

	//
	// TargetRules interface.
	//

/*	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "seattlevrhack18" } );
	}*/
}
