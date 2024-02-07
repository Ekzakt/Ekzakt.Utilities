﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ekzakt.Utilities.Extentions.Tests
{
    [TestClass()]
    public class LongExtensionsTests
    {
        [TestMethod()]
        public void FormatFileSizeTest_ShouldReturnKB()
        {
            long value1 = 1024;
            long value2 = 15645;

            var result1 = value1.FormatFileSize(2);
            var result2 = value2.FormatFileSize(2);

            Assert.IsTrue(result1 == "1,00 KB" && result2 == "15,28 KB");
        }


        [TestMethod()]
        public void FormatFileSizeTest_ShouldReturnMB()
        {
            long value1 = 1048576;
            long value2 = 1085426;

            var result1 = value1.FormatFileSize(2);
            var result2 = value2.FormatFileSize(2);

            Assert.IsTrue(result1 == "1,00 MB" && result2 == "1,04 MB");
        }
    }
}