# Advanced Compiler Design and Simulation - HibbanScript

This is a semester-level Compiler Construction project developed using C# Windows Forms. The project simulates the main phases of a compiler for a custom programming language named HibbanScript.

## Features

- Lexical Analysis
- Token Table Generation
- Symbol Table Generation
- FIRST Set
- FOLLOW Set
- DFA Validation
- SLR Parser / Syntax Analysis
- Parse Tree / Syntax Tree
- Semantic Analyzer
- Intermediate Code Generation
- Code Optimization
- Final Target Code Generation
- Run All button for complete compiler execution

## Technologies Used

- C#
- Windows Forms
- .NET Framework
- Visual Studio

## Compiler Flow

Source Code → Lexical Analysis → Symbol Table → SLR Parser → Parse Tree → Semantic Analysis → Intermediate Code → Optimization → Final Code

## Demo Sequence

1. Load Sample
2. Run All

## Project Description

The compiler takes source code written in HibbanScript and processes it through multiple compiler phases. It identifies tokens, stores variable details in the symbol table, checks syntax using an SLR parser, generates a parse tree, performs semantic analysis, creates intermediate code, optimizes the code, and finally generates pseudo assembly target code.
