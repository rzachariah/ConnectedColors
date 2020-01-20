# ConnectedColors
Answering Google Tech Lead's interview question

## Background
Find Google Tech Lead's presentation of his interview question (here)[https://medium.com/free-code-camp/bet-you-cant-solve-this-google-interview-question-4a6e5a4dc8ee]

## Problem
Given a grid of colored cells, find the maximum number of connected colors.

The problem is a variation of the Flood Fill algorithm.

## Domain
I introduce a Color enum and a Node type. The Node includes coordinates, a Color and a Processed flag (to avoid redundant work).

## Algorithm
FindMaxConnectedColors iterates over all nodes and applies CountConnected to each. CountConnected will return the number of connected colors reachable from the starting cell. Importantly, it will also mark each cell it visits as Processed. We return the maximum result of CountConnected.

CountConnected applies Depth First search to find all connected nodes. I included both Recursive and Iterative implementations.

## Run-Time
Both solutions are linear with the size of the matrix, or O(MN) for a matrix of M rows and N columns. Each cell in the matrix is visited once.

## Trade-offs
The Recursive solution is a bit neater, but suffers from StackOverflow on a large enough input.

## Solution
A dotnetcore (2.2) solution is provided. You can download dotnetcore for your platform (here)[https://dotnet.microsoft.com/download]

## Unit tests
Tests of both approaches are provided. To execute run
```
dotnet test
```

