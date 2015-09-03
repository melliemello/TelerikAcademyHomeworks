/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName`, `age` and `marks` properties
        *   `marks` is an array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (students) {
  	var student = _.chain(students)
  	.each( function(student){
  		var markSum = _.reduce(student.marks, function(avg, num){
  			return avg + num;
  		}, 0);
  		var averageMark = markSum / student.marks.length;
  		student.averageMark = averageMark;
  	})
  	.sortBy(function(student){
  		return -student.averageMark;
  	})
  	.first()
  	.value();

  	console.log(student.firstName + ' ' + student.lastName + ' has an average score of ' + student.averageMark);
  };
}

module.exports = solve;
