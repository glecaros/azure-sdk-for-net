// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Chat;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.AI.Chat.Samples
{
    public partial class Samples_ChatClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Create_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ChatClient client = new ChatClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                messages = new object[]
            {
new
{
content = "<content>",
role = "user",
}
            },
                stream = false,
            });
            Response response = client.Create(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("message").GetProperty("content").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("message").GetProperty("role").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("finish_reason").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Create_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ChatClient client = new ChatClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                messages = new object[]
            {
new
{
content = "<content>",
role = "user",
}
            },
                stream = false,
            });
            Response response = await client.CreateAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("message").GetProperty("content").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("message").GetProperty("role").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("finish_reason").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Create_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ChatClient client = new ChatClient(endpoint, credential);

            ChatCompletionOptions chatCompletionOptions = new ChatCompletionOptions(new ChatMessage[]
            {
new ChatMessage("<content>", ChatRole.User)
            });
            Response<ChatCompletion> response = client.Create(chatCompletionOptions);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Create_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ChatClient client = new ChatClient(endpoint, credential);

            ChatCompletionOptions chatCompletionOptions = new ChatCompletionOptions(new ChatMessage[]
            {
new ChatMessage("<content>", ChatRole.User)
            });
            Response<ChatCompletion> response = await client.CreateAsync(chatCompletionOptions);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Create_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ChatClient client = new ChatClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                messages = new object[]
            {
new
{
content = "<content>",
role = "user",
session_state = new object(),
}
            },
                stream = false,
                session_state = new object(),
                context = new
                {
                    key = new object(),
                },
            });
            Response response = client.Create(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("message").GetProperty("content").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("message").GetProperty("role").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("message").GetProperty("session_state").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("session_state").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("context").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("finish_reason").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Create_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ChatClient client = new ChatClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                messages = new object[]
            {
new
{
content = "<content>",
role = "user",
session_state = new object(),
}
            },
                stream = false,
                session_state = new object(),
                context = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("index").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("message").GetProperty("content").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("message").GetProperty("role").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("message").GetProperty("session_state").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("session_state").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("context").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("choices")[0].GetProperty("finish_reason").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Create_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ChatClient client = new ChatClient(endpoint, credential);

            ChatCompletionOptions chatCompletionOptions = new ChatCompletionOptions(new ChatMessage[]
            {
new ChatMessage("<content>", ChatRole.User)
{
SessionState = BinaryData.FromObjectAsJson(new object()),
}
            })
            {
                SessionState = BinaryData.FromObjectAsJson(new object()),
                Context =
{
["key"] = BinaryData.FromObjectAsJson(new object())
},
            };
            Response<ChatCompletion> response = client.Create(chatCompletionOptions);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Create_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ChatClient client = new ChatClient(endpoint, credential);

            ChatCompletionOptions chatCompletionOptions = new ChatCompletionOptions(new ChatMessage[]
            {
new ChatMessage("<content>", ChatRole.User)
{
SessionState = BinaryData.FromObjectAsJson(new object()),
}
            })
            {
                SessionState = BinaryData.FromObjectAsJson(new object()),
                Context =
{
["key"] = BinaryData.FromObjectAsJson(new object())
},
            };
            Response<ChatCompletion> response = await client.CreateAsync(chatCompletionOptions);
        }
    }
}
