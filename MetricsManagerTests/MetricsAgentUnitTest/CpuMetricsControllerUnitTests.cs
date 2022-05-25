namespace MetricsManagerTests.MetricsAgentUnitTest
{
    public class CpuMetricsControllerUnitTests
    {
        private MetricsAgent.Controllers.CpuMetricsController controller;
        public CpuMetricsControllerUnitTests()
        {
            controller = new MetricsAgent.Controllers.CpuMetricsController();
        }

        [Fact]
        public void GetMetricsByPercent_ReturnsOk()
        {
            //Arrange
            var percentile = 50;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = controller.GetMetricsByPercent(fromTime, toTime, percentile);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetMetricsByTime_ReturnsOk()
        {
            //Arrange
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = controller.GetMetricsByTime(fromTime, toTime);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
