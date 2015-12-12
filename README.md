# Final-Project
This is a simple piece of Odometer tracking software created for a final project at SWATC for the Visual Basic programming course.

The following is a summation of the program in the format of an IPO

Input: Current Mileage

Output: Trip Mileage, Current Mileage and Previous Mileage

Programming:
  trip mileage = current mileage - previous mileage
  
   The Odometer Program automatically scans the previous.txt file located in the bin/debug folder. It will then display the last
   line of this file in the "Previous Reading" label.
   
   When the user enters the current Odometer reading and clicks on calculate, the program will deduct the "previous reading" value
   from the value entered in the text box. The program will then display the result in the trip label. 
   
   The current total label inherits the value entered into the text box.  This value is also passed to the "previous.txt" file where
   it is written into the file.
   
   If a second odometer reading is entered, all values will be updated. The last Odometer reading entered
   becomes the "new" previous entry and everything else is calculated using this new entry.
   
   The "previous.txt" file will update the program each time the program is executed.  This way values entered during
   previous instances of the program will persist each time the program is run
   
   As a side note, you can open previous.txt to examin all previous odometer readings.
   
