# EasyResult

**EasyResult** is a simple and flexible library designed to standardize the handling of results and errors in your .NET applications. It provides a straightforward way to represent success and failure outcomes with helpful status codes and messages.

## Features

- **Simple Result Handling**: Easily handle success and failure cases in a consistent manner.
- **Customizable Status Codes**: Assign and manage status codes for different scenarios.
- **Flexible Error Messaging**: Provide detailed error messages for better diagnostics.

## Installation

- **Right-click on your project in Solution Explorer and select "Manage NuGet Packages..."
- **Search for "EasyResult" in the Browse tab.
- **Click "Install" to add the package to your project.


## Usage
### Creating a Success Result
To create a result indicating a successful operation:

```csharp
var successResult = Result<int>.SendSuccess(42);
```

### Creating a Failure Result

```csharp
var failureResult = Result<int>.SendFailure("An error occurred.");
```

### Handling Results
To access the result data and status:

```csharp
if (successResult.IsSuccessful)
{
    Console.WriteLine($"Success: {successResult.Data}");
}
else
{
    Console.WriteLine($"Error: {successResult.ErrorMessages}");
}
```

##Example
Here is a complete example demonstrating how to use EasyResult:

```csharp
public class Example
{
    public Result<int> Divide(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            return Result<int>.SendFailure("Cannot divide by zero.");
        }

        int result = dividend / divisor;
        return Result<int>.SendSuccess(result);
    }
}
```

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Contact
For any questions or feedback, please contact Orçun Gökoluk.

## Source Code

[![GitHub](https://img.shields.io/badge/GitHub-EasyResult-blue?logo=github)](https://github.com/orcungokoluk/EasyResult)