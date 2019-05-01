using UnityEditor;
using UnityEngine;

namespace UPMTest
{
	public static class Example
	{
		[MenuItem( "Tools/Hoge" )]
		private static void Hoge()
		{
			Debug.Log( "ピカチュウ" );
		}
	}
}