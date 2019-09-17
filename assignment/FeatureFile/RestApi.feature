Feature: Validation the working of API on reqre.in
  
 
	   Scenario Outline: Successful registration
       When I register with  <email> and <password>
       Then Registeration should be successfull
       And Token shoud be returned

	   Examples: 
       | email              | password |
       |eve.holt@reqres.in     | pistol   | 


	   Scenario Outline: Unsuccessful registration
        When I register with  <email> and <password>
       Then The registeration should not be successfull

       Examples: 
      | email           | password |
      | sandeep.@gmail.com | Gupta    |

	  Scenario: List Users
      When user send a GET request
      Then should be getting a list of users


