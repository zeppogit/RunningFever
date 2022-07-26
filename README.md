## RunningFever

# Introduction
This repository is for Code Louisville Software Path Course 2, Spring 2022.  This is bare bones, and even intentionally lacking some more obvious properties to practice adding them after the intial ORM mapping, building and scaffolding.  A follow up repo BreakingRunningFever will be used for future practice.

# Description
Just a place to note the days I jog, the route I took, and the distance, along with other notes if I choose, such as what nagging injury is rearing its ugly head that day. 

# Tech
- **Backend** - C# 10, .NET 6
- **ORM** - Entity Framework Core 6
- **Database** - SQLite
- **Frontend** - Razor / HTML / CSS

# Pattern
- MVC
- Code First
- built with CLI and Visual Studio Code (I installed the C# for VS Code powered by OmniSharp extension) with Windows 10

# Getting Started
- Clone the repo or download zip file and unzip
- Open the the RunningFeverRepo folder in Visual Studio Code
- You may get a prompt to restore dependencies that refer to the C# for VS Code by OmniSharp extension-- if so, click restore
- Open the terminal in VS Code and navigate to the app folder, e.g.:
                 cd RunningFever\RunningFeverApp
- Next in terminal type 'dotnet run' without the quotes and hit Enter
- Follow instructions and hit ctrl key while clicking on one of the provided links to load web app into a browser

### Include three items from Feature List:

√ - Read data from an external file (SQLite database) and use that data in your application

√ - Include a class that is inherited by another which uses one or more of the parent properties 

√ - Visualize data in a graph, chart, or other visual representation of data (database data displayed in rows and columns on page) 

√ - Use a LINQ query to retrieve info from a data structure such as a list or an array (or from a file).   (Controllers using LINQ to retrieve from database)

√ - Create a list or dictionary, populate it with values, retrieve at least one value and use it. (create IEnumerable model, and iterate with foreach for display use)
	