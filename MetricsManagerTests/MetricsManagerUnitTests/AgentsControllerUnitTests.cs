namespace MetricsManagerTests.MetricsManagerUnitTests
{
    public class AgentsControllerUnitTests
    {
        private AgentsController controller;
        private Lesson1_MetricsManager.AgentInfo agentInfo;
        public AgentsControllerUnitTests()
        {
            controller = new AgentsController();
            agentInfo = new Lesson1_MetricsManager.AgentInfo();
        }

        [Fact]
        public void RegisterAgent_ReturnsOk()
        {
            //Arrange

            //Act
            var result = controller.RegisterAgent(agentInfo);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void Read_ReturnsOk()
        {
            //Arrange

            //Act
            var result = controller.Read();

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void EnableAgentById_ReturnsOk()
        {
            //Arrange
            var agentid = 1;
            //Act
            var result = controller.EnableAgentById(agentid);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void DisableAgentById_ReturnsOk()
        {
            //Arrange
            var agentid = 1;
            //Act
            var result = controller.EnableAgentById(agentid);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
