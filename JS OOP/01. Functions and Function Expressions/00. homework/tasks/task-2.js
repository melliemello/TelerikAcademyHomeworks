/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from,to) {
	var from = +from,
		to= +to,
		primes = [],
		maxDivisor,
		isPrime;

	if(arguments.length != 2){
		throw new Error();
	}

	for(var number = from; number <= to; number++){
		isPrime = true;
		for(var divisor = 2; divisor <= Math.sqrt(number); divisor++){
			if(!(number % divisor)){
				isPrime = false;
				break;
			}
		}
		if(isPrime && number > 1){
			primes.push(number);
		}
	}
	return primes;
}

module.exports = findPrimes;
