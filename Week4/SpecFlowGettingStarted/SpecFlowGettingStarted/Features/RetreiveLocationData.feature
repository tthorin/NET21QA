Feature: Retreive location data based on country and zip code

As a consumer of the Zippopotamus.us API 
I want to recieve location data matching the country code and zip code I supply
So I can use this data to auto-complete forms on my web-site


Scenario Outline: Country and zip codes yield the right place names
Given the country code <countryCode> and zip code <zipCode>
When  I request the location corresponding to these codes
Then the response contains the name <placeName>
Examples: 
| countryCode | zipCode | placeName     |
| us          | 90210   | Beverly Hills |
| us          | 22222   | Arlington     |


#Scenario: Country code us and zip code 90210 yields Beverly Hills as a place name
#	Given the country code us and zip code 90210
#	When I request the locations corresponding to these codes
#	Then the response contains the name Beverly Hills
#
#Scenario: Country code us and zip code 22222 yields Arlington as a place name
#	Given the country code us and zip code 22222
#	When I request the locations corresponding to these codes
#	Then the response contains the name Arlington