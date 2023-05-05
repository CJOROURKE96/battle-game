A turn based battle game that plays out within the console. 

To run the application on your own machine follow these steps: 

- Clone the repo to your own machine

- Set up dotnet on your machine. This quick 5 minute tutorial will take you through the steps (https://www.youtube.com/watch?v=DAsyjpqhDp4)

- Once you have dotnet insatlled, along with the extension to VS Code called C#. You should now be able to run dotnet commands in your terminal. 

- The first command you should run is: 

dotnet build

- This command will compile (build) the program and also let you know if there are any warnings or errors. 

- If the build is successful then you're ready to run the program. To run the program, in your terminal type:

dotnet run

- This command will then run your code in the terminal and display the game in your terminal.

- The game will prompt you to input either a to attack, or h to heal. Once you have selected your letter simply press enter to allow the program to randomly generate the enemy's turn. 

- If you alter the code, then attempt to run the program you will need to run the following command before building and running the program again: 

dotnet clean