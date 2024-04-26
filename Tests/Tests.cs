using System;
using NUnit.Framework;
using ClassLibrary.Services;
using Moq;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CalcPremium_RuralLocationYoungDriver_ReturnsCorrectPremium()
        {
            // Arrange
            var discountService = new Mock<DiscountService>();
            discountService.Setup(m => m.GetDiscount()).Returns(1.0); // No discount applied
            var insuranceService = new InsuranceService(discountService.Object);

            int age = 25;
            string location = "rural";

            double expectedPremium = 5.0;

            // Act
            double actualPremium = insuranceService.CalcPremium(age, location);

            // Assert
            Assert.AreEqual(expectedPremium, actualPremium);
        }

        [Test]
        public void CalcPremium_RuralLocationExperiencedDriver_ReturnsCorrectPremium()
        {
            // Arrange
            var discountService = new Mock<DiscountService>();
            discountService.Setup(m => m.GetDiscount()).Returns(1.0); // No discount applied
            var insuranceService = new InsuranceService(discountService.Object);

            int age = 40;
            string location = "rural";

            double expectedPremium = 3.50;

            // Act
            double actualPremium = insuranceService.CalcPremium(age, location);

            // Assert
            Assert.AreEqual(expectedPremium, actualPremium);
        }

        [Test]
        public void CalcPremium_RuralLocationInvalidAge_ReturnsZeroPremium()
        {
            // Arrange
            var discountService = new Mock<DiscountService>();
            discountService.Setup(m => m.GetDiscount()).Returns(1.0); // No discount applied
            var insuranceService = new InsuranceService(discountService.Object);

            int age = 17;
            string location = "rural";

            double expectedPremium = 0.0;

            // Act
            double actualPremium = insuranceService.CalcPremium(age, location);

            // Assert
            Assert.AreEqual(expectedPremium, actualPremium);
        }

        [Test]
        public void CalcPremium_UrbanLocationYoungDriver_ReturnsCorrectPremium()
        {
            // Arrange
            var discountService = new Mock<DiscountService>();
            discountService.Setup(m => m.GetDiscount()).Returns(1.0); // No discount applied
            var insuranceService = new InsuranceService(discountService.Object);

            int age = 28;
            string location = "urban";

            double expectedPremium = 6.0;

            // Act
            double actualPremium = insuranceService.CalcPremium(age, location);

            // Assert
            Assert.AreEqual(expectedPremium, actualPremium);
        }

        [Test]
        public void CalcPremium_UrbanLocationExperiencedDriver_ReturnsCorrectPremium()
        {
            // Arrange
            var discountService = new Mock<DiscountService>();
            discountService.Setup(m => m.GetDiscount()).Returns(1.0); // No discount applied
            var insuranceService = new InsuranceService(discountService.Object);

            int age = 55;
            string location = "urban";

            double expectedPremium = 5.0;

            // Act
            double actualPremium = insuranceService.CalcPremium(age, location);

            // Assert
            Assert.AreEqual(expectedPremium, actualPremium);
        }

        [Test]
        public void CalcPremium_UrbanLocationInvalidAge_ReturnsZeroPremium()
        {
            // Arrange
            var discountService = new Mock<DiscountService>();
            discountService.Setup(m => m.GetDiscount()).Returns(1.0); // No discount applied
            var insuranceService = new InsuranceService(discountService.Object);

            int age = 15;
            string location = "urban";

            double expectedPremium = 0.0;

            // Act
            double actualPremium = insuranceService.CalcPremium(age, location);

            // Assert
            Assert.AreEqual(expectedPremium, actualPremium);
        }

        [Test]
        public void CalcPremium_InvalidLocation_ReturnsZeroPremium()
        {
            // Arrange
            var discountService = new Mock<DiscountService>(); // Assuming you're using a mocking framework
            discountService.Setup(m => m.GetDiscount()).Returns(1.0); // No discount applied (optional)
            var insuranceService = new InsuranceService(discountService.Object);

            int age = 30;
            string location = "invalid"; // Invalid location

            double expectedPremium = 0.0;

            // Act
            double actualPremium = insuranceService.CalcPremium(age, location);

            // Assert
            Assert.AreEqual(expectedPremium, actualPremium);
        }

    }
}