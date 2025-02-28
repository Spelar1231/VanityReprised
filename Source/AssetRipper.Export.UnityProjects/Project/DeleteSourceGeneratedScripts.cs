using AssetRipper.Export.UnityProjects.Configuration;
using AssetRipper.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetRipper.Export.UnityProjects.Project
{
	public sealed class DeleteSourceGeneratedScripts : IPostExporter
	{
		public void DoPostExport(GameData gameData, LibraryConfiguration settings)
		{
			string scriptsDirectory = Path.Combine(settings.AssetsPath, "Scripts");
			string[] scriptsToDelete =
			{
				Path.Combine(scriptsDirectory, "Assembly-CSharp", "UnitySourceGeneratedAssemblyMonoScriptTypes_v1.cs"),
				Path.Combine(scriptsDirectory, "Naelstrof.JigglePhysics", "UnitySourceGeneratedAssemblyMonoScriptTypes_v1.cs"),
				Path.Combine(scriptsDirectory, "NewBlood.LegacyInput", "UnitySourceGeneratedAssemblyMonoScriptTypes_v1.cs"),
			};

			foreach (string scriptPath in scriptsToDelete)
			{
				if (File.Exists(scriptPath))
					File.Delete(scriptPath);
			}
		}
	}
}
