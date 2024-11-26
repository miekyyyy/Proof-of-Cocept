using SimpleMqtt;

var client = SimpleMqttClient.CreateSimpleMqttClientForHiveMQ("client-id");

await client.PublishMessage("hoiii", "TestTopic");
