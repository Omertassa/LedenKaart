Feature: Importeren van een bestand

Background: Program is active

Scenario: Importing a file that is in use gives the right result. 
Given The file to be imported is already in use by another program
When I press the Import button
And When I select the file
Then A messagebox will appear with an error message
And The right panel will not be accesible
And The Status label will say "Hi"

