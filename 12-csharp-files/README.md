# C#: Working with Files

> Part of the [Alura .NET Backend Career](https://www.alura.com.br/carreiras/desenvolvimento-backend-net) path.

## Project — ByteBank I/O

A dedicated project exploring file I/O in .NET. The application reads and writes bank account data (`CheckingAccount` and `Customer`) using progressively higher-level abstractions — from raw byte buffers to `StreamReader`/`StreamWriter` and finally `BinaryReader`/`BinaryWriter`. Each technique is isolated in its own file using the `partial class` modifier.

---

## Features Developed

| File | Technique |
|------|-----------|
| `1_DirectFileStreamRead.cs` | Reads a file in 1KB byte chunks using `FileStream` + buffer |
| `2_UsingStreamReader.cs` | Reads a `.txt` file line by line, parses each CSV line into a `CheckingAccount` object |
| `3_DirectFileStreamWrite.cs` | Writes raw bytes directly to a file using `FileStream` + `Encoding.UTF8.GetBytes()` |
| `4_UsingStreamWriter.cs` | Writes text to a file using `StreamWriter` with explicit `Flush()` |
| `5_UsingBinaryWriter.cs` | Writes primitive values to a binary file using `BinaryWriter` |
| `6_UsingBinaryReader.cs` | Reads primitive values back from a binary file using `BinaryReader` |

---

## Concepts Covered

- **Streams** — understanding streams as sequences of bytes that abstract reading and writing from any source or destination
- **`FileStream`** — opening a file for direct byte-level access with `FileMode.Open` and `FileMode.Create`
- **`FileMode.Create` vs `FileMode.CreateNew`** — `Create` overwrites if the file exists; `CreateNew` throws if it does
- **Buffer and `Read()`** — reading large files in fixed-size byte chunks to avoid loading the entire file into memory at once
- **`Encoding.UTF8`** — decoding a byte buffer into a readable string with `GetString()` and encoding text into bytes with `GetBytes()`
- **Unicode and UTF encoding** — understanding how character encoding works in the decoding process
- **`StreamReader`** — reading text files with higher-level methods: `ReadLine()`, `ReadToEnd()`, `Read()`, and the `EndOfStream` property
- **CSV parsing** — splitting a delimited line with `.Split(';')` and converting each field with `int.Parse()` and `decimal.Parse()`
- **`StreamWriter` and `Flush()`** — writing text through a buffered writer and forcing the buffer to flush immediately to the file
- **`BinaryWriter`** — writing typed primitive values (`int`, `decimal`, `string`) directly to a binary stream
- **`BinaryReader`** — reading typed primitive values back from a binary stream with `ReadInt32()`, `ReadDecimal()`, and `ReadString()`
- **`partial class`** — splitting a class definition across multiple files to organize each technique in isolation while sharing the same `Program` class
- **`using` statement for streams** — ensuring streams are properly closed and resources released after use, replacing the explicit `Close()` call
- **Console as a stream** — understanding that `Console.In` and `Console.Out` are streams, and using `Console.OpenStandardInput()` to access the standard input stream directly
- **`File` helper class** — using static methods on `File` for common operations like creating, copying, and opening files

---

## How to Run

**Requirements:** [.NET 10 SDK](https://dotnet.microsoft.com/download)

```bash
cd ByteBank_IO
dotnet run
```

> To test each technique, uncomment the corresponding method call in `Program.cs`.

---

## Tech Stack

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)