# RelativeDateTimeAndNumber
A relative date time and numbers library class for .Net

# Usage

```csharp
 long number = 1234567890;

// Short Format in english
Console.WriteLine(number.ToRelativeString("us", true));  // Output: "1 B"

// Long Format in english
Console.WriteLine(number.ToRelativeString("us", false)); // Output: "1 billion"

// Formato corto en español
Console.WriteLine(number.ToRelativeString("es", true));  // Output: "1 B"

// Formato largo en español
Console.WriteLine(number.ToRelativeString("es", false)); // Output: "1 billones"


// With Dates

DateTime pastDate = DateTime.Now.AddDays(-10); 
Console.WriteLine(pastDate.AsRelative("us", false)); // Output: "10 days" (english) or "10 días" (spañol)

```
