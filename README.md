# Programming Assignment

## Task description

Your task is to write a C# program that provides correct results for an office property search.

The correct results are defined as such:
- Any combination of units from the same building (the name of each building is unique).
- The total square footage of the units is between the bounds provided, inclusive of the bound itself.

### Examples

Given the following buildings and units:

| Building | Floor | Sqft |
| --- |-------| --- |
| Dunder Mifflin | -1    | 10 |
| Dunder Mifflin | 0     | 15 |
| Dunder Mifflin | 1     | 20 |
| Dunder Mifflin | 2     | 50 |
| Dunder Mifflin | 3     | 5 |
| JLB Credit | 0     | 10 | 
| JLB Credit | 1     | 40 |

#### Example 1

For a search of 0 to 10 square foot, we'd expect:

| Building | Floor | Sqft |
| --- |-------| --- |
| Dunder Mifflin | -1    | 10 |
| Dunder Mifflin | 3     | 5 |
| JLB Credit | 0     | 10 | 

#### Example 2

For a search of 25 to 40 square foot, we'd expect:

| Building | Floor | Sqft |
| --- |-------| --- |
| Dunder Mifflin | -1    | 10 |
| Dunder Mifflin | 0     | 15 |
| Dunder Mifflin | 1     | 20 |
| Dunder Mifflin | 3     | 5 |
| JLB Credit | 1     | 40 |

## Instructions

To get you started, we've already provided a stubbed type `Solution` which provides 
the correct function signatures, namely `Add` and `Search`. You will use `Add`
to store buildings in-memory such that their units will be made available in a
call to `Search`. There is no need to change code outside the `Solution` package.

All the types are in the Buildings file, including a helper function to get all unit combinations
for a given building. There's no need to change anything in here. 

As part of this assignment, we will need to see evidence that you have verified the
functionality of your solution.

## Bonus Points

- Can you optimise this for searching?
- Comment on how might you improve the interface of `Solution`?