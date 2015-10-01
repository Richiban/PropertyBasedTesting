# PropertyBasedTesting

This is an exploration of the concepts of Property Based Testing introduced to me by reading Mark Seeman's and Scott Wlashin's blogs.

I have started with the idea of unit testing the plus operator (+). How would you normally test this? Asserting that 1 + 1 = 2? and that 2 + 3 = 5? Where do you stop?

Normally you could generate some random input data, such as two ints `x` and `y`. But how do you know the expected answer, when you can't calculate it? After all, you can't
use addition to calculate the expected answer when addition is the very operation you're testing!

The anwer is: property-based testing. We're using the mathematical definition of the word 'property' right now, and examples of mathematical properties might be:
* associativity
* commutativity
* idempotency 
* etc

If we generate random input data as before, but test the result of the function for its mathematical properties instead of the exact value of the result, we can end up with
robust unit tests that should hold true for any given values x and y and that it is hard to fake.