# Temperature Converter

Develop a temperature converter program in C# that converts temperature values between Fahrenheit and Celsius.


### Main Features 

- Function TempConvert should receive 2 parameters: the amount of temperature, and the original measurement unit
- Function TempConvert should return the string, containing new temperature and new unit.
- Implement comprehensive error handling for invalid inputs (non-numeric values, unsupported scales).

### Other Features 

- The application should prompt the user to enter a temperature value and a scale (Celsius 'C' or Fahrenheit 'F').
- The program should continuously prompt the user for input until the user enters `Quit`.

```
// Expected output
Enter a temperature and its unit (C or F), or type 'Quit' to exit:
> 30 X
Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.

Enter a temperature and its unit (C or F), or type 'Quit' to exit:
> forty-five C
Invalid input. Please enter a numeric temperature.

Enter a temperature and its unit (C or F), or type 'Quit' to exit:
> 45 C
Converted: 45 C = 113 F

Enter a temperature and its unit (C or F), or type 'Quit' to exit:
> Quit
Program terminated.

```
