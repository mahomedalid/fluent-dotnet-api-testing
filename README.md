# FATcore - Fluent API Testing in .netcore

This is a C# NuGet library that provides a fluent approach for integration or system testing over APIs or REST Http Endpoints.

## Features

* Fluent API for building HTTP requests with various methods (GET, POST, PUT, DELETE, etc.)
* Easy authentication setup (Basic Auth, OAuth, JWT)
* Automatic serialization and deserialization of JSON payloads
* Built-in support for popular assertion libraries (NUnit, xUnit, MSTest)
* Ability to run tests in parallel for faster execution
* Extensible architecture for customizing and extending functionality

## Installation

To install the FATcore library, run the following command in the Package Manager Console:

```
Install-Package ...
```

## Usage

Here's an example of how to use the library to test a simple API endpoint:

```
[Test]
public void TestApiEndpoint()
{
    var client = new ApiClient("https://api.example.com");

    var response = client.Get("/users")
        .WithQueryParam("name", "John")
        .WithBasicAuth("username", "password")
        .Execute();

    Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

    var users = response.Deserialize<List<User>>();
    Assert.That(users, Has.Exactly(1).Matches<User>(u => u.Name == "John"));
}
```

## Contributing

Contributions to the API Testing Library are welcome! Please see the CONTRIBUTING.md file for more information.

## License

The FATcore library is licensed under the MIT License.
