# Lab02-Unit-Testing
**Version**: 1.0.0  
**Author**: Ben Taylor

## Overview
A command-line mock-banking application.

## Getting Started
1. Create a fork of this repository, and clone your fork to your device.
2. Open the solution file `ATM.sln` in Visual Studio.
3. To run the app, go to `Debug` > `Start Without Debugging` (or press Ctrl+F5).
4. For testing, navigate to the `ATM-Tests` project using the Solution Explorer.
5. To run the tests, go to `Tests` > `Run` > `All Tests` (or press Ctrl+R)

## Using The Application
![Screenshot](https://github.com/BenSTay/Lab02-Unit-Testing/blob/master/assets/screenshot.webp)
1. Upon opening the application, you will be asked what kind of transaction you wish to make. Follow the on-screen instructions to make a transaction. (You will start with an account balance of $5000).
2. If you choose to deposit or withdraw money, you will then be asked how much money you wish to deposit/withdraw. Enter a value to complete the transaction. (Note: digits below the hundredths position will be ignored when completing the transaction).
3. After the transaction has been completed, you will be asked if you want to make another transaction. Selecting "y" will return you to the main menu. Selecting "n" will exit the application.

## Architecture
**Languages Used**:
* C# 7.3 (.NET Core 2.2)  
Written with Visual Studio Community 2017.

## Change Log
* 20-03-19 10:47AM - Initial Version
