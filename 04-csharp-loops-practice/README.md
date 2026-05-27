# Practicing C#: Loops

> Part of the [Alura .NET Backend Career](https://www.alura.com.br/carreiras/desenvolvimento-backend-net) path.

## About

A collection of practical exercises focused on repetition structures in C#. Each file contains the exercise description as a comment, followed by the solution.

---

## Exercises

| File | Description |
|------|-------------|
| `MultiplicationTable.cs` | Prints the multiplication table of 7 from 1 to 10 using a `for` loop |
| `SkippingNumbers.cs` | Displays numbers from 1 to 20, skipping multiples of 3 using `continue` |
| `NumberClassification.cs` | Traverses a list of scores and classifies each as passed or failed |
| `HowManyOddNumbersWereEntered.cs` | Reads 10 integers and counts how many are odd |
| `TheRightLoopForTheProblem.cs` | Traverses a grade list with `foreach` and alerts students below average |
| `SumOfSales.cs` | Accumulates daily sale values with `do/while` until the user enters 0 |
| `InventoryControl.cs` | Manages product stock entries with a `while` loop until the user exits |
| `SecretNumber.cs` | Guess-the-number game using `while (true)` with `break` on correct answer |
| `SearchingAList.cs` | Searches a student list with `while` and exits early with `break` on match |
| `TemperatureConverter.cs` | Menu-driven temperature converter repeating with `do/while` until exit |
| `ServiceQueueTickets.cs` | Ticket queue system combining `do/while` and `switch/case` for service management |

---

## Concepts Covered

- **`for` loop** — iterating a fixed number of times with a counter variable
- **`foreach` loop** — traversing collections without managing an index manually
- **`while` loop** — repeating while a condition is true, evaluated before each iteration
- **`do/while` loop** — guaranteeing at least one execution before checking the condition
- **`break`** — immediately exiting a loop when a condition is met
- **`continue`** — skipping the current iteration and proceeding to the next
- **`while (true)`** — intentional infinite loop controlled exclusively by `break`
- **Modulus operator (`%`)** — checking divisibility for odd/even and multiple detection
- **Accumulators** — summing or counting values across iterations with compound assignment operators
- **Loop and conditional combination** — applying `if/else` and `switch/case` inside loops for richer logic
- **Number formatting** — using `ToString("D3")` for zero-padded output and `:F2` for decimal precision