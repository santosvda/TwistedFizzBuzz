# TwistedFizzBuzz

## 📌 Overview
TwistedFizzBuzz is a flexible C# library that extends the classic FizzBuzz problem by supporting:
- Custom number ranges
- Non-sequential numbers
- User-defined divisors and tokens
- API-generated tokens for dynamic FizzBuzz replacements

The project includes:
- **TwistedFizzBuzz Library**: Core logic for generating FizzBuzz sequences
- **RegularFizzBuzzConsole**: A basic console application implementing standard FizzBuzz
- **TwistedFizzBuzzConsole**: A more advanced console application demonstrating custom divisors and tokens
- **TwistedFizzBuzz.Tests**: Unit tests ensuring correctness

---

## 📂 Project Structure
```
/TwistedFizzBuzzLib           # Core library
  ├── TwistedFizzBuzz.cs      # Main logic
  ├── Dto/ApiResponseDto.cs   # API response model
/RegularFizzBuzzConsole       # Standard FizzBuzz implementation
/TwistedFizzBuzzConsole       # Advanced example with custom tokens
/TwistedFizzBuzz.Tests        # Unit tests (xUnit)
  ├── TwistedFizzBuzzTokenTests.cs # Standard tests
  ├── TwistedFizzRegularTests.cs     # API-based tests with Moq
  ├── EdgeCaseTests.cs        # Boundary conditions
```

---

## 🚀 Features
### 🔹 Standard FizzBuzz
Generate a FizzBuzz sequence for a given range.
```csharp
var result = TwistedFizzBuzz.RegularFizzBuzz(1, 20);
```
### 🔹 Non-Sequential Input
Process an arbitrary set of numbers.
```csharp
var numbers = new[] { 5, 9, 15, 27 };
var result = TwistedFizzBuzz.NonSequentialFizzBuzz(numbers);
```
### 🔹 Custom Divisors & Tokens
Define your own replacement words.
```csharp
var tokens = new Dictionary<int, string> { { 7, "Foo" }, { 11, "Bar" } };
var result = TwistedFizzBuzz.TwistedFizzBuzzTokens(1, 20, tokens);
```
### 🔹 API-Generated Tokens
Fetch FizzBuzz replacements from an external API.
```csharp
var result = await TwistedFizzBuzz.ApiGeneratedTokensFizzBuzz(1, 50);
```

---

## 🛠 Setup & Installation
### 🔹 Prerequisites
- .NET 6 SDK or later

### 🔹 Clone the Repository
```sh
git clone https://github.com/santosvda/TwistedFizzBuzz.git
cd TwistedFizzBuzz
```
### 🔹 Build the Solution
```sh
dotnet build
```
### 🔹 Run Console Applications
```sh
dotnet run --project RegularFizzBuzzConsole

dotnet run --project TwistedFizzBuzzConsole
```
### 🔹 Run Tests
```sh
dotnet test
```

---

## 📖 Usage
### 🔹 Example Output
```
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
```

For custom tokens `{ 5 -> "Foo", 9 -> "Bar", 27 -> "Baz" }`, output looks like:
```
1
2
3
4
Foo
6
7
8
Bar
Foo
```

---

## 🧪 Running Unit Tests
Tests are written in xUnit and can be run using:
```sh
dotnet test
```
To enable live testing:
```sh
dotnet watch test
```

---

🚀 **Happy coding!**

