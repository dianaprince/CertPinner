﻿using NUnit.Framework;

namespace CertPinner.AutoPinPolicies
{
	[TestFixture]
	public class AlwaysAutoPinTests
	{
		[Test]
		public void CanPin_ReturnsTrue()
		{
			// Arrange
			var instance = new AlwaysAutoPin();

			// Act
			var result = instance.CanPin("anything");

			// Assert
			Assert.IsTrue(result);
		}
	}
}
