Feature: SkycopSteps

Scenario: Open Skycop claims page 
	Given I navigate to claims
	Then I set Kaunas as departure airport
	And I set London Gatwick as arrival airport
	And I choose airlines
	And I set flight number
	And I set flight date
	And I choose the problem of the flight encountered
	And I choose how long delayed
	And I choose when informed
	And I choose reason provided
	And I choose where hear about
	And I click next step button
	And I describe situation
	And I set flight reservation number
	And I click enter travellers details
	And I fill name field
	And I fill surname field
	And I fill birthdate field
	And I fill email field
	And I fill repeat email field
	And I set user phone 
	And I fill address
	And I fill city
	And I fill post code
	And I set country
	And I set language
	And I choose travelling alone
	And I click on terms check
	And I click final step butoon
	And I sign