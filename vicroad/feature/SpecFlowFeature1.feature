Feature: Test
Background: 
Given User visits vicroads website

Scenario: Scenario tests one day price for pass of passenger vehicle
	Given User selects passenger vehicle 
    And fills information
    When User clicks calculator - Submit Order
    Then Pass amount is calculated and User is taken to next pages

    Scenario: Scenario tests permit price for Goods carrying vehicle
    Given newUser selects Goods carrying vehicle
    And newUser selects carrying vehicle type
    And newUser fills Address
    And newUser fills the Permit Date
    And newUser fills the Permit Duration
    And newUser clicks calculator - Submit Order
    Then Pass amount is calculated and newUser is taken to next pages