# _Repeat Count_

#### _Enter a phrase and count the instances of a word in that phrase, 7/8/2016_

#### By _**Alan Denison**_

## Description
A program that will allow a user to enter a phrase, then a word contained in that phrase. After submitting the form, the program will count the number of times the entered word appears in the created phrase.

specs:

it should find if a word exists in a phrase, this is done first to make sure it can search for multiple words eventually:
  input: "duck", "duck"
  output: "1"

It should count all instances of the words found, now that we can tell if the phrase does contain the word:
  input "duck duck goose", "duck"
  output "2"

It should ignore case when searching for words:
  input "duck", "Duck"
  output "1"

It should ignore partial word matches when searching for words:
  input "Duckworth the duck"
  output "1"

## Setup/Installation Requirements
Instructions for Windows PC.
Get windows here: (http://www.mono-project.com/docs/getting-started/install/windows/)

1. From Powershell, clone this repository using the command 'git clone https://github.com/alandenison/CountWords.git'
2. Navigate to project directory
3. Run the command 'dnu restore' to get dependencies
4. Use the command 'dnx kestrel' to run the kestrel server
5. Open a browser and go to: localhost:5004

## Technologies Used

C#, Razor, Nancy, Xunit
### License
MIT/open source license


Copyright (c) 2016 **_Alan Denison_**
