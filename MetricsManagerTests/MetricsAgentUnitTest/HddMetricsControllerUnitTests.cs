using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsManagerTests.MetricsAgentUnitTest
{
    public class HddMetricsControllerUnitTests
    {
        private MetricsAgent.Controllers.HddMetricsController controller;
        public HddMetricsControllerUnitTests()
        {
            controller = new MetricsAgent.Controllers.HddMetricsController();
        }

        [Fact]
        public void GetMetrics_ReturnsOk()
        {
            //Arrange
            var freeSpace = "5 GB";

            //Act
            var result = controller.GetMetrics(freeSpace);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
