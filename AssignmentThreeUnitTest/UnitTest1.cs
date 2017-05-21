using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using assignment_3;
using NUnit.Framework;

namespace AssignmentThreeUnitTest
{
	[TestFixture]
	public class UnitTest1
	{
		[Test]
		public void CheckScoreHasUpdatedCorrectly()
		{
			int actual, expected;
			GameWindow gw = new GameWindow();

			//	Refactored to include ref type and changed all points methods 
			//	from return methods to void methods.
			actual = gw.AddTry(10);
			expected = 17;
			Assert.AreEqual(actual, expected);

			actual = gw.AddConversion(10);
			expected = 12;
			Assert.AreEqual(actual, expected);

			actual = gw.AddPenalty(10);
			expected = 13;
			Assert.AreEqual(actual, expected);

			actual = gw.AddDropKick(10);
			expected = 13;
			Assert.AreEqual(actual, expected);
		}

		[Test]
		public void CheckingWinnerIsCorrect([Values(14)] int value1, [Values(17)] int value2,
			[Values("New Zealand")] string team1, [Values("France")] string team2)
		{
			string actual, expected;
			GameWindow gw = new GameWindow();

			actual = gw.Winner(value1, value2, team1, team2);
			expected = "WINNER is: " + team2;

			Assert.AreEqual(actual, expected);
		}

		[Test] //	The GameWindow methods have been commented out for functionality reasons once
			   //	the all tests passed.
		public void CheckingWhetherRightStatsAreShowing()
		{
			string actual, expected;
			int stat = 1;
			GameWindow gw = new GameWindow();

			//	While testing, I used optional arguments to reduce code.
			//	Also changed DetermineStatConcat from return to void methods.
			actual = gw.DetermineStatConcat(stat);
			expected = "Tries: 1";
			Assert.AreEqual(actual, expected);

			actual = gw.DetermineStatConcat(0, stat);
			expected = "Conversions: 1";
			Assert.AreEqual(actual, expected);

			actual = gw.DetermineStatConcat(0, 0, stat);
			expected = "Penalties: 1";
			Assert.AreEqual(actual, expected);

			actual = gw.DetermineStatConcat(0, 0, 0, stat);
			expected = "Drop Kicks: 1";
			Assert.AreEqual(actual, expected);
		}

		[Test]
		public void CheckingTimerEngineIncreaseCorrectly()
		{
			int actual = 0, expected;
			GameWindow gw = new GameWindow();

			//	Removed parameters while refactoring.
			//	For the code to work I've had to remove the parameters once the a passed test was achieved.
			actual += gw.TimerEngine(10, 59);
			expected = 1;
			Assert.AreEqual(actual, expected);

		}
	}
}
