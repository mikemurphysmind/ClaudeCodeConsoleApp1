# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a .NET 8.0 C# console application solution. The solution contains a single console application project: `ClaudeTestConsoleApp1`.

## Build and Run Commands

### Build the solution
```bash
dotnet build
```

### Build specific project
```bash
dotnet build ClaudeTestConsoleApp1/ClaudeTestConsoleApp1.csproj
```

### Run the application
```bash
dotnet run --project ClaudeTestConsoleApp1/ClaudeTestConsoleApp1.csproj
```

### Clean build artifacts
```bash
dotnet clean
```

### Restore dependencies
```bash
dotnet restore
```

## Project Configuration

- **Target Framework**: .NET 8.0
- **Output Type**: Console executable
- **Nullable**: Enabled
- **Implicit Usings**: Enabled
- **Solution File**: `ClaudeTestProjects.sln`

## Architecture

This is a simple console application with a single entry point in `Program.cs`. The project uses .NET 8.0's minimal top-level statements pattern.
