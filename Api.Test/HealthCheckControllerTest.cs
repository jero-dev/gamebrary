using Api.Controllers;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;

namespace Api.Test
{
    public class HealthCheckControllerTest
    {
        [Test]
        public void HealthCheck_Must_return_a_Ok_200_response()
        {
            var controller = new HealthCheckController();

            var response = controller.HealthCheck();

            Assert.That(((OkObjectResult)response).StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void HealthCheck_Must_return_a_message_with_the_response()
        {
            var controller = new HealthCheckController();

            var response = controller.HealthCheck();

            Assert.That(((OkObjectResult)response).Value, Is.EqualTo("I'm alive!"));
        }
    }
}