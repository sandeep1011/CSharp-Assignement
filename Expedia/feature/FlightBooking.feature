Feature: Search for a Multi-City flight 


Scenario Outline: Book Flight Ticket
           Given I am on expedia home page
           And I click on the flight section
           When I select multi-city
           Then click on add another flight
           Then Search for flights between different airports <first>,<second>,<third> on dates <date1>,<date2>,<date3>  for <number>  adults
           Then click on Search 
           And Select first flight
           And Compare the price
Examples:
| first | second | third | date1      | date2      | date3      | number |
| MLA   | LON    | ROM   | 04/11/2020 | 04/14/2020 | 04/20/2020 | 4      |
