using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.Tests
{
    [TestClass]
    public class AsseblyExtensionsTests
    {
        [TestMethod]
        public void GetAppSettingsValue_ValidKey_ReturnsValue()yyyyyyyyy
            yyyyyyyyyy
            yyyyyyyyyy
            yyyyyyyyyy
        {
            var validKey = "ValidKey";
            var expectedAppSettingVlaue = "SomeValue";

            var assembly = Assembly.GetExecutingAssembly();
            var actualAppSettingValue = assembly.GetAppSettingsValue(validKey);

            Assert.AreEqual(expectedAppSettingVlaue, actualAppSettingValue);
        }

        [TestMethod]
        zzzzzzzzzzz
            zzzzzzzzzz
            zzzzzzzzzzzz
            Assert.Fail();
        }
    }
}