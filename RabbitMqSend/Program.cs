// See https://aka.ms/new-console-template for more information
using RabbitMQ.Client;
using System.Text;

for (int i = 0; i < 10; i++)
{
    sendMessage();
}
static void sendMessage()
{
    var factory = new ConnectionFactory();
    factory.Uri = new Uri("amqps://hbsgfopi:iXqCwnImBKdL82fmx_rSb1xQI1dUYc_2@fish.rmq.cloudamqp.com/hbsgfopi");

    using var connection = factory.CreateConnection();

    var channel = connection.CreateModel();

    channel.QueueDeclare("message-queue", true, false, false);

    var message = "Example Message";
    var body = Encoding.UTF8.GetBytes(message);

    channel.BasicPublish(String.Empty, "message-queue", null, body);

    Console.WriteLine(message);

    Console.ReadLine();
}