# 03d3d7e2-f374-491e-a48b-7ecfdf8860d4

Longest Increasing Subsequence (LIS) – .NET Solution

This repository contains a .NET 10 solution that calculates the Longest Increasing Subsequence (LIS) from a space-separated list of numbers. It includes a console application, core library, unit tests, Docker support, and CI/CD with code coverage reporting.

Project Structure

LIS-Repository/
|
|-- src/
|   |-- LIS.Core/      (Core LIS algorithm logic)
|   |-- LIS.App/       (Console application)
|
|-- tests/
|   |-- LIS.Tests/     (xUnit test project)
|
|-- .github/
|   |-- workflows/     (GitHub Actions CI pipeline)
|
|-- Dockerfile
|-- LIS.sln
|-- README.md


Prerequisites

Before running the application, ensure you have:

.NET SDK 10.0+
Docker (optional, for container execution)
Git
1. Clone the Repository
git clone https://github.com/sandeep-sajonia/03d3d7e2-f374-491e-a48b-7ecfdf8860d4.git
cd 03d3d7e2-f374-491e-a48b-7ecfdf8860d4

2. Restore Dependencies
dotnet restore

3. Build the Solution
dotnet build

4. Run the Console Application
dotnet run --project src/LIS.App
Example Input:
Enter numbers (space-separated):
1 5 9 2 3 4 5 6 9 1 2 3
Example Output:
Result: 2 3 4 5 6 9

Type q to exit the application.

5. Run Unit Tests
dotnet test

This runs all xUnit tests in the solution.

6. Code Coverage

Run tests with coverage:

dotnet test --collect:"XPlat Code Coverage"
Generate HTML report:
reportgenerator -reports:**/coverage.cobertura.xml -targetdir:coverage-report -reporttypes:Html
View report:

Open: coverage-report/index.html

7. Run with Docker

Open the command terminal and navigate to the project directory, then execute the following commands:
The project directory should contain the Dockerfile.
For this solution, the Dockerfile is located at the root of the repository which is "03d3d7e2-f374-491e-a48b-7ecfdf8860d4".

Before running the Docker commands, ensure you have Docker installed and running on your machine.
You can download Docker from https://www.docker.com/get-started.
To verify that Docker is installed correctly, you can run the following command in your terminal:
# Below command will display the installed Docker version
$ docker --version

Build Docker Image
$ docker build -t lis.app .

Run Container
$ docker run -it lis.app

8. CI/CD with GitHub Actions

The repository includes automated pipeline:

What it does:
	Builds solution
	Runs tests
	Generates code coverage
	Publishes artifacts
	Trigger:
	Push to main
	Pull requests

Workflow file:
.github/workflows/lis-build-test-deploy.yml

9. Core Feature
Longest Increasing Subsequence

The core algorithm is implemented in:

src/LIS.Core/LongestSubsequence.cs

It calculates the longest increasing sequence from a space-separated string of integers.

10. Example Usage (Code)
	
	// Example usage in a console application
	using LIS.Core;
			
	var longestSubsequence = new LongestSubsequence();
    var input = "1 5 9 2 3 4 5 6 9 1 2 3";
	var result = longestSubsequence.GetLongestSubsequence(input);

	Console.WriteLine(result);