Feature: Calculator

    Scenario: Add two numbers for SUM
    Given the first number is -50
    And the second number is -50
    When the two numbers are added for Sum
    Then the result should be -100

    Scenario: Add two numbers for Minus
    Given the first number is -50
    And the second number is -50
    When the two numbers are added for Minus
    Then the result should be 0

    Scenario: Add two numbers for Divide
    Given the first number is -50
    And the second number is -50
    When the two numbers are added for Divide
    Then the result should be 1

    Scenario: Add two numbers for Multiply
    Given the first number is -50
    And the second number is -50
    When the two numbers are added for Multiply
    Then the result should be 1
