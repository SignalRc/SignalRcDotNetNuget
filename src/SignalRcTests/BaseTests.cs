using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SignalRc.Helpers;
using SignalRc.Models;

namespace SignalRcTests
{
    [TestClass]
    public class BaseTests
    {
        [TestMethod]
        public void ShouldCreate()
        {
            var model = new SignalRcModel();
        }

        [TestMethod]
        public void ShouldValidate()
        {
            var result = ValidateModel.Validate(new SignalRcModel
            {
                Self = Guid.NewGuid().ToString(),
                Version = "1.0.0",
                Vehicles = new Dictionary<string, VehicleStateModel>
                {
                    { "s", new VehicleStateModel() }
                }
            });
            result.Count().Should().Be(0);
        }

        [TestMethod]
        public void ShouldNotValidate()
        {
            var result = ValidateModel.Validate(new SignalRcModel());
            result.Count().Should().Be(3);
        }
    }
}