// See https://aka.ms/new-console-template for more information

using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory();
factory.Uri = new Uri("amqps://hbsgfopi:iXqCwnImBKdL82fmx_rSb1xQI1dUYc_2@fish.rmq.cloudamqp.com/hbsgfopi");

using var connection = factory.CreateConnection();

var channel = connection.CreateModel();

channel.QueueDeclare("message-queue", true, false, false);

var consumer = new EventingBasicConsumer(channel);
channel.BasicConsume("message-queue", true, consumer);

consumer.Received += Consumer_Received ;

Console.ReadLine();

void Consumer_Received(object? sender, BasicDeliverEventArgs e)
{
    Console.WriteLine("Incomming Message: " + Encoding.UTF8.GetString(e.Body.ToArray()));
}