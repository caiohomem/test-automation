Feature: Test WebSite
	Test the functionalities of the site

@PageNavigation
Scenario: Navigate to About Page
	Given the user navigate to about page
	Then the title of the page must the about

@PageNavigation
Scenario: Navigate to Contact Page
	Given the user navigate to contact page
	Then the title of the page must the contact

@PageNavigation
Scenario: Navigate to Home Page
	Given the user navigate to home page
	Then the title of the page must the home

@Login
Scenario: Login
	Given the user register a new random user
	And try to login with the user
	Then the user must be logged in
