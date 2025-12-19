# GodMorgenProgram
- There is a dictionary with greetings for different times of the day.
- Each key ("morning", "afternoon", "evening", "night") has a list of greeting messages.

- There is another dictionary with special greetings for specific names
(for example: if the name is "Albina", the greeting is "Kjør på").

- A random generator is used to choose a random greeting.

- The program starts and repeats in a loop forever.

- The user is asked to enter their name or type "exit" to quit.

- If the user enters nothing, the program asks again.

- If the user types "exit", the loop stops and the program ends.

- The screen is cleared, and a message is shown:
“{name}, welcome to Good Morning app”.

- The program checks if the entered name is in the special greetings list.
If it is, the special greeting is shown to the user.

- If the name is not special, the program checks the current hour of the day
and decides the time period:

 Between 5 and 12 → morning

 Between 12 and 18 → afternoon

 Between 18 and 21 → evening

 Any other time → night

- Based on this time period, the program chooses the list of greetings
for morning, afternoon, evening, or night.

- From that list, the program picks a random greeting and displays it.

- After showing the greeting, the loop repeats and the user is asked for a name again.
