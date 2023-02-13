# BugTracker
This is a Windows Forms application for tracking and reporting Bugs, there will be two ways to save the Data, either by SQL or with CSV files, The current way to change how the data is stored and where are in the App.config file. you need to change the filePath and change the Database connections inside Program.cs, this is done by chagning the .Sql to .TextFile and vice versa.

This version is functional for sql use, however the csv based system currently has no way to update or remove reports.

I also want to update the UI slightly as it is not the most beautiful program.

I also want to use inheritance between forms more often as when an item is added updated or removed it will not be visible under some circumstances until a reboot of the software. With more inheritance I will be less reliant on SQL stored procedures as data can be passed easily from one form to another meaning that I wont have to do another call just to find the id or name of an environment.

The attatchment functionality is also not working, I had the uploading of attatchments working with them being saved in a format which could be read correctly by the program, however there were some issues with showcasing them back to the user, This could be fixed by limiting the types of attatchments the user could store but I would also need to create a feature to dynamically load each attatchment, an easy way to do this would be to open the file explorer and only display the relevant files.
