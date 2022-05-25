using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsManagerTests.MetricsAgentUnitTest
{
    public class NetworkMetricsControllerUnitTests
    {
        private MetricsAgent.Controllers.NetworkMetricsController controller;
        public NetworkMetricsControllerUnitTests()
        {
            controller = new MetricsAgent.Controllers.NetworkMetricsController();
        }

        [Fact]
        public void GetMetrics_ReturnsOk()
        {
            //Arrange
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = controller.GetMetrics(fromTime, toTime);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
