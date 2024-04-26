using Azure.AI.OpenAI;

namespace TestAzureAIOpenAI {
internal class Program {
	static void Main(string[] args) {
		var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY") ?? throw new Exception("OPENAI_API_KEY not set");
		var client = new OpenAIClient(apiKey);
	}
}
}
