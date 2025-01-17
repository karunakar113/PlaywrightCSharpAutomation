Feature: Flipkart
	Simple calculator for adding two numbers

@mytag
Scenario: Add A product to flipkart and validate product
Given Iam on the Flipkart homepage
When I search for "iphone 15 pro max 256 gb" product
And Select first product
Then verify product
	