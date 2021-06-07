Feature: calculator
Simple calculator for adding two numbers

    @mytag
    Scenario: Add two numbers
        Given the first number is 50
        And the second number is 70
        When the two expression type equals 'add'
        Then the result should be 120

    @mytag
    Scenario: subtract two numbers
        Given the first number is 50
        And the second number is 70
        When the two expression type equals 'sub'
        Then the result should be -20

    @mytag
    Scenario: multiply two numbers
        Given the first number is 50
        And the second number is 70
        When the two expression type equals 'mul'
        Then the result should be 3500

    @mytag
    Scenario: divide two numbers
        Given the first number is 9
        And the second number is 3
        When the two expression type equals 'div'
        Then the result should be 3

    @mytag
    Scenario: Add two numbers without expression
        Given the first number is 50
        And the second number is 70
        When expression is not defined
        Then the result should be 0