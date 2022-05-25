namespace MetricsManagerTests.MetricsAgentUnitTest
{
    public class RamMetricsControllerUnitTests
    {
        private MetricsAgent.Controllers.RamMetricsController controller;
        public RamMetricsControllerUnitTests()
        {
            controller = new MetricsAgent.Controllers.RamMetricsController();
        }

        [Fact]
        public void GetMetrics_ReturnsOk()
        {
            //Arrange
            var available = "5 GB";

            //Act
            var result = controller.GetMetrics(available);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
