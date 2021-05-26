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


## To check the solution You have:
Check your solution with running the following command (after making sure its safe of course). It will also print what to do for the next excercise:
```
chmod 755 check.sh && ./check.sh
```
