/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
  function validateCourseTitle(title){
    if(!(/^((?!\s{2}).)*[^\s]+$/.test(title)) ||
          !(/^[^\s]/.test(title)) ||
          !title.length){
      throw new Error();
    }
  }

  function getValidatedFullName(names){
    var fullname = names.split(' '),
        fname = fullname[0],
        lname = fullname[1];

    if(fullname.length > 2){
      throw new Error();
    }

    if(!(/([A-Z]{1}[a-z]*$)/.test(fname)) ||
        !(/([A-Z]{1}[a-z]*$)/.test(lname)) ||
          fname.length * lname.length === 0){
      throw new Error();
    }
    return fullname;
  }

  function validateStudentID(id, students){
    var student = students.filter(function(element){
      return element.id === id;
    });

    if(!student.length){
      throw new Error();
    }
  }

  function validateHomeworkID(homeworkID, presentations){
    if(!presentations[homeworkID - 1]){
      throw new Error();
    }
  }

  function validateResults(results){
    if(this._scores[results.StudentID] || isNaN(Number(results.Score))){
      throw new Error();
    }
  }

  function calculateStudentResult(student, scores, homeworks){
    var homeworksResult = 0;
    homeworks.reduce(function(res, curr){;
      res += curr
    }, homeworksResult);
    homeworksResult /= homeworks.length;
    return (0.25 * homeworksResult) + (scores[student.id] * 0.75);
  }

	var Course = {
		init: function(title, presentations) {
      validateCourseTitle(title);
      if(presentations.length){
        presentations.forEach(function(element){
          validateCourseTitle(element);
        });
      }
      else{
        throw new Error();
      }
      this._title = title;
      this._presentations = presentations;
      this._students = [];
      this._scores = {};
      this._homeworks = {};
      return this;
		},

		addStudent: function(name) {
      var nameArray = getValidatedFullName(name);
      var id = this._students.length + 1;
      this._students.push({
        firstname: nameArray[0],
        lastname: nameArray[1],
        id: id
      });

      return id;
		},

		getAllStudents: function() {
      return this._students.slice();
		},

		submitHomework: function(studentID, homeworkID) {
      validateStudentID(studentID, this._students);
      validateHomeworkID(homeworkID, this._presentations);
      this._homeworks[studentID] = this._homeworks[studentID] || [];
      this._homeworks[studentID].push(homeworkID);
		},

		pushExamResults: function(results) {
      results.forEach(function(){
        validateStudentID(results.StudentID);
        validateResults(results);
        this._scores[results.StudentID] = results.Score;
      });
		},

		getTopStudents: function() {
      return this._students.sort(function(a,b){
        aResult = calculateStudentResult(a, this._scores, this._homeworks);
        bResult = calculateStudentResult(b, this._scores, this._homeworks);
        return bResult - aResult;
      }).slice(0,10);
		}
	};

	return Course;
}


module.exports = solve;
