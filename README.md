# LINQ Tutorial

Welcome to the LINQ Tutorial!

This tutorial consists of a bunch of excercises. Yout can start an excercise by merging the excercise branch to your local branch.

## Start here
To start a new solution, open a new branch with:
```
git checkout -b 'my-solution'
```
To list the git branches with the excercises run:
```
git branch | grep excercise-
```
To list the git branches with the solutions run:
```
git branch | grep answer-
```
Let's start with the first excercise by running:
```
git merge excercise-general-001
```
Whenever the command `dotnet test` passes, you can consider the excercise passed and merge the next excercise.

The list of assignments will be here at the end of the README.md file.

## 🎉🎉🎉 Congratulations! You made it to the first excercise! 🎉🎉🎉

### excercise-general-001
In this excercise you will need to make a test project. Do it by running the command:
```
dotnet new sln -n LinqTutorial &&
  dotnet new mstest -o LinqTutorial.Tests &&
  dotnet sln LinqTutorial.sln add LinqTutorial.Tests/ &&
  sed -i '' 's/\r$//' LinqTutorial.Tests/LinqTutorial.Tests.csproj LinqTutorial.Tests/UnitTest1.cs LinqTutorial.sln
```

### excercise-linq-basics-001
In this excercise, you will need to make an enumerable of 3 zeroes. Google `Enumerable.Repeat` for hints.

### excercise-linq-basics-002
In this excercise, you will need to make an enumerable that retruns the numbers 1, 2 and 3. Google `Enumerable.Range` for hints.

### excercise-linq-basics-003
Notice we have a new project in the solution: `LinqTutorial.Implementation`. It has one namespace currently with the new record type `LinqTutorial.Implementation.Stables.Horse`. For these line of excercises, you can assume this is a third-party library, therefore **you can not change the code of `LinqTutorial.Implementation`**. Your task is to make the test green (as always). Use the `Select` method to do so.

### excercise-linq-basics-004
The task is exactly the same as in 003, but you will have to use query syntax for this one. Google `Linq query syntax` to get some tips how to do that.

### excercise-linq-basics-005
Your task is to filter the horses to keep only the lucky ones with the `Where` method. Notice the new property `IsLucky` of the `Horse` type.

### excercise-linq-basics-006
Your task is to create a `Dictionary<int, Horse>` where the keys are the ids of the horses. You will need to use the `IEnumerable.ToDictionary` method. Note that there is no query syntax-equivalent of the `ToDictionary` method.

### excercise-linq-basics-007
You decide that there is no need to store all the horses in the dictionary, you will only need whether they are lucky or not. You decide that luck shouldn't be only a boolean flag, you decide to indicate luck with the new and more sophisticated `Luck` enum.

Take a look at the test file `LinqTutorial.Tests/LinqBasics/LinqBasicsTests.cs`. You will notice that it already contains the new test using the new `Luck` enum, but it doesn't work. If you accept the suggestion in the comment, it won't even compile because there is no `GetLuck` function provided in the `Horse` type.

The `Horse` class is still in a third-party library, **you can not change its code**. However, you can make an extension method that can be used like it would be a method of the `Horse` type.

Note the new source file `LinqTutorial.Tests/LinqBasics/Horses.cs`.

Your task is to create the extension method in the `Horses` class, that does the same as the following lambda function:
```
Func<Horse, Luck> GetLuck = horse => horse.IsLucky ? Luck.Lucky : Luck.Unlucky;
```
Google `C# extension methods` for a hint.

### excercise-linq-basics-008
The next dictionary you will need for your work is one that maps the Luck enum value to the number of horses there are in the enumerable. Google `Linq group by` for a hint. Notice that there are separate tests for method and query syntax solutions.

### excercise-linq-basics-009
Note the new type `Bet` in `LinqTutorial.Implementation/Stables/Bet.cs`.

We have now horses as well as bets for the horses. If the horse is lucky the bet amount counts as positive, negative otherwise. Your task is to determine much win/loss there is for each bet. To determine that, you will need to join the two data sets together. Google both `Linq join query syntax` and `Linq join method syntax` for hints.


## To check the solution You have:
Check your solution with running the following command (after making sure its safe of course). It will also print what to do for the next excercise:
```
chmod 755 check.sh && ./check.sh
```
