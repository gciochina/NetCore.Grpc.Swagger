using Grpc.Net.Client;
using System;

namespace Coding.Dona.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			// The port number(5001) must match the port of the gRPC server.
			using var channel = GrpcChannel.ForAddress("https://localhost:60387");
			var client = new Greeter.GreeterClient(channel);
			var reply = client.SayHello(new HelloRequest { Name = "GreeterClient" });
			Console.WriteLine("Greeting: " + reply.Message);
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
