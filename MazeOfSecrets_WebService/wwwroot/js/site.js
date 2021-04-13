// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
void GetData()
{
    var client = new RestClient("http://localhost:63489/api/MazeDataItems");
    client.Timeout = -1;
    var request = new RestRequest(Method.POST);
    request.AddHeader("Content-Type", "application/json");
    request.AddParameter("application/json", "{\r\n    \"userId\":21,\r\n    \"question\":\"test 123456\",\r\n    \"correctAnswer\":\"curr ans 234sdf56\",\r\n    \"wrongAnswer1\":\"wrong anssdfwer 1\",\r\n    \"wrongAnswer2\":\"wrong anssdfwer 2\"\r\n}", ParameterType.RequestBody);
    IRestResponse response = client.Execute(request);
    Console.WriteLine(response.Content);
}
