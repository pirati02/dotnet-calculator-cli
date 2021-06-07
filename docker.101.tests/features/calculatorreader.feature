Feature: calculatorreader
    Calculator feature scenarios

    @mytag
    Scenario: Put empty arghuments
        When expression is empty
        Then the expression should be 0

    @mytag
    Scenario: Put invalidvalid arguments
        When 'invalid'
        Then the expression should be 0
 
    @mytag
    Scenario: Put valid arguments add
        When expression '-e' is 'add', numberOne '3' and '4'
        Then the expression should be 1

    @mytag
    Scenario: Put valid arguments sub
        When expression '-e' is 'sub', numberOne '3' and '4'
        Then the expression should be 2

    @mytag
    Scenario: Put valid arguments mul
        When expression '-e' is 'mul', numberOne '3' and '4'
        Then the expression should be 3

    @mytag
    Scenario: Put valid arguments div
        When expression '-e' is 'div', numberOne '3' and '4'
        Then the expression should be 4