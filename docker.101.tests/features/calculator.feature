Feature: calculator
Simple calculator for adding two numbers

    @mytag
    Scenario: Add two numbers with expression
        Given the first number is 50
        And the second number is 70
        When the two expression type equals 'add'
        Then the result should be 120

    @mytag
    Scenario: Add two numbers without expression
        Given the first number is 50
        And the second number is 70
        When expression is not defined
        Then the result should be 0