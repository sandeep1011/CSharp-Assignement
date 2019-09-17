Feature: Validation of Sign in Functionality
  
Scenario Outline: SignIn With Credentials
	Given we are on Login page
	When Click on Sign In
	And User enter <email> and <password>
	When user Click on Sign In Button    
	Then An email address required should be visible
Examples:
| email                      | password |
|                            |          |
| sandeepgupta4512@gmail.com |          |
|                            |  98765   |
| sandeepgupta4512@gmail.com | 98765    |
   