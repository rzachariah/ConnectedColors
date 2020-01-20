# ConnectedColors
Answering Google Tech Lead's interview question

## Background
Watch Google Tech Lead's presentation of his interview question [here](https://youtu.be/IWvbPIYQPFM).

## Problem Summarized
Given a grid of colored cells, find the maximum number of connected colors. The problem is a variation of Flood Fill.

## Domain
I introduce a Color enum and a Node type. The Node includes coordinates, a Color and a Processed flag (to avoid redundant work).

## Algorithm
Iterate over all nodes and apply Depth First Search to each. The DFS will return the count of connected colors reachable from the starting cell. Importantly, it will also mark each cell it visits as Processed. We return the maximum result.

Both recursive and iterative solutions are possible. I included both.

## Run-Time
Both solutions are linear with the size of the matrix, or O(MN) for a matrix of M rows and N columns. Each cell in the matrix is visited once.

## Trade-offs
The Recursive solution is a bit neater, but suffers from StackOverflow on a large enough input.

## Solution
A dotnetcore (2.2) solution is provided. You can download dotnetcore for your platform [here](https://dotnet.microsoft.com/download)

## Unit tests
Tests of both approaches are provided. To execute run
```
dotnet test
```

## Blog Post
On medium [here](https://medium.com/@ranjithzachariah/connectedcolors-6a84ad3d1e97)
