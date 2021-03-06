param($installPath, $toolsPath, $package, $project)
 
	Add-Type -AssemblyName 'Microsoft.Build, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
    $msbuild = [Microsoft.Build.Evaluation.ProjectCollection]::GlobalProjectCollection.GetLoadedProjects($project.FullName) | Select-Object -First 1
 
    $projectUri = new-object Uri('file://' + $project.FullName)
    $targetUri = new-object Uri('file://' + $targetsFile)
    $relativePath = $projectUri.MakeRelativeUri($targetUri).ToString().Replace([System.IO.Path]::AltDirectorySeparatorChar, [System.IO.Path]::DirectorySeparatorChar)

	$import = $msbuild.Xml.Imports | where {$_.Project.Contains("WP7CI.targets")} | select -first 1
 
	if ($import)
	{
		$msbuild.Xml.RemoveChild($import) | out-null
		$project.Save()
	}