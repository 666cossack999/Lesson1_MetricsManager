namespace MetricsManagerTests.MetricsAgentUnitTest
{
    public class DotNetMetricsControllerUnitTests
    {
        private MetricsAgent.Controllers.DotNetMetricsController controller;
        public DotNetMetricsControllerUnitTests()
        {
            controller = new MetricsAgent.Controllers.DotNetMetricsController();
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
