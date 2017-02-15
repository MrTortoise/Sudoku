# Sudoku

a series of 40 min katas to solve

1. tried to solve a single row in isolation. Felt bad as solution was tied to string. Also had no way of knowing order if 2 items missing.


2. Used an array of a valid as golden master, then blanked out points and tried to solve. Got row and column based solutions working provided that each solver step results in a filling in of a blank - otherwise infinite recursion. Failed to figure out in 2 mins at the end what condition i need to force me to evaluate a 3x3 block to solve.