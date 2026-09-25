using NorskaLib.Spreadsheets;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	[CreateAssetMenu(fileName = "TestGoogleSheet", menuName = "Game/Google Sheet Editor/TestGoogleSheet")]
	public class TestGoogleSheet : SpreadsheetsContainerBase
	{
		[SpreadsheetContent]
		[SerializeField]
		private TestSheetContent content;

		public TestSheetContent _0024a => _0024WX();

		public TestSheetContent _0024WX()
		{
			return null;
		}
	}
}
