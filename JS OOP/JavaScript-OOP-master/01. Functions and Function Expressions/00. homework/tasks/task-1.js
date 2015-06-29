/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(array) {
	if(array.length ===0){
		return null;
	}

	return array.reduce(function(s,a){
		if(isNaN(Number(a))){
			throw new Error();
		}
		return s + +a;
	},0)
}

module.exports = sum;